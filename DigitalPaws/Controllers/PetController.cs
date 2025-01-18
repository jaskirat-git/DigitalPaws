using DigitalPaws.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace DigitalPaws.Controllers
{
	public class PetController : Controller
	{
		private DigitalPawsContext _context;
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult AddPet()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddPet(Pet pet)
		{
			pet.OwnerId = int.Parse(HttpContext.Session.GetString("UserId"));
			_context.Pets.Add(pet);
			_context.SaveChanges();
			return RedirectToAction("ViewPets");
		}
		[HttpGet]
		public IActionResult ViewPets()
		{
			int userId = int.Parse(HttpContext.Session.GetString("UserId"));
			var pets = _context.Pets.Where(p => p.OwnerId == userId).ToList();
			return View(pets);
		}


	}
}
