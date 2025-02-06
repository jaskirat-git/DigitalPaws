using DigitalPaws.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using System.Drawing;
using System.Drawing;
using System.IO;
using System.Linq;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace DigitalPaws.Controllers
{
	public class PetController : Controller
	{
		private DigitalPawsContext _context;
		public PetController(DigitalPawsContext context)
		{
			_context = context; // Properly initialize the context here
		}
		public IActionResult Index()
		{
			return View();
		}
		// GET: Add Pet
		[HttpGet]
		public IActionResult Add()
		{
			ViewBag.Categories = new List<string> { "Dog", "Cat", "Bird", "Rabbit", "Reptile", "Other" };
			return View();
		}

		[HttpPost]
		public IActionResult Add(Pet pet, IFormFile? DisplayPictureUrl)
		{
			int? userId = HttpContext.Session.GetInt32("UserId");
			if (userId == null)
				return RedirectToAction("Login", "Account");

			if (ModelState.IsValid)
			{
				pet.OwnerId = userId.Value;

				// Handle Display Picture Upload
				HandleProfilePicture(DisplayPictureUrl, pet);
				// Generate QR Code
				string qrCodePath = GenerateQRCode(pet);
				pet.QRCodeUrl = qrCodePath;

				_context.Pets.Add(pet);
				_context.SaveChanges();

				return RedirectToAction("ViewPets");
			}

			ViewBag.Categories = new List<string> { "Dog", "Cat", "Bird", "Rabbit", "Reptile", "Other" };
			return View(pet);
		}




		private string GenerateQRCode(Pet pet)
		{
			var owner = _context.Users.FirstOrDefault(u => u.Id == pet.OwnerId);
			if (owner == null)
			{
				throw new Exception("Owner not found!");
			}

			string qrText = $"Pet Name: {pet.Name}, Owner Name: {owner.Name}, Mobile: {owner.MobileNumber}";

			// Create the QR code data with a medium error correction level
			using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
			{
				QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
				PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
				byte[] qrCodeImage = qrCode.GetGraphic(20);

				// Generate a unique file name
				string fileName = $"{Guid.NewGuid()}.png";
				string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "qr-codes");
				string filePath = Path.Combine(uploadFolder, fileName);

				// Ensure the directory exists
				Directory.CreateDirectory(uploadFolder);

				// Save the file using a FileStream
				using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					fileStream.Write(qrCodeImage, 0, qrCodeImage.Length);
				}

				return $"/qr-codes/{fileName}";
			}
		}



		[HttpGet]
		public IActionResult ViewPets()
		{
			int? userId = HttpContext.Session.GetInt32("UserId");
			if (userId == null)
			{
				return RedirectToAction("Login", "Account");
			}

			// Fetch pets owned by the logged-in user
			var pets = _context.Pets.Where(p => p.OwnerId == userId.Value).ToList();

			return View(pets); // Pass the list of pets to the ViewPets.cshtml
		}

		private void HandleProfilePicture(IFormFile? profilePic, Pet pet)
		{
			if (profilePic != null && profilePic.Length > 0)
			{
				string fileExtension = Path.GetExtension(profilePic.FileName);
				string uniqueFileName = Guid.NewGuid().ToString() + fileExtension;
				string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
				string filePath = Path.Combine(uploadFolder, uniqueFileName);

				Directory.CreateDirectory(uploadFolder);

				using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					profilePic.CopyTo(fileStream);
				}

				pet.DisplayPictureUrl = "/images/" + uniqueFileName;
			}

		}

	}
}
