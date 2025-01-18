using DigitalPaws.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DigitalPaws.Controllers
{
	public class AccountController : Controller
	{
		private readonly DigitalPawsContext _context;

		public AccountController(DigitalPawsContext context)
		{
			_context = context;
		}

		// GET: Account/Register
		public IActionResult Register()
		{
			return View();
		}

		// POST: Account/Register
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Register(User user)
		{
			if (ModelState.IsValid)
			{
				// Check if username already exists
				if (_context.Users.Any(u => u.Username == user.Username))
				{
					ModelState.AddModelError("Username", "This username is already taken.");
					return View(user);
				}

				_context.Users.Add(user);
				_context.SaveChanges();
				TempData["SuccessMessage"] = "Registration successful. Please log in.";
				return RedirectToAction("Login");
			}

			return View(user);
		}

		// GET: Account/Login
		public IActionResult Login()
		{
			return View();
		}

		// POST: Account/Login
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Login(string username, string password)
		{
			var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
			if (user != null)
			{
				// Store user info in session
				HttpContext.Session.SetString("Username", user.Username);
				HttpContext.Session.SetInt32("UserId", user.Id);

				TempData["SuccessMessage"] = "Welcome, " + user.Name + "!";
				return RedirectToAction("Profile");
			}

			ModelState.AddModelError("", "Invalid username or password.");
			return View();
		}

		// GET: Account/Logout
		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			TempData["SuccessMessage"] = "You have successfully logged out.";
			return RedirectToAction("Login");
		}

		// GET: Account/Profile
		public IActionResult Profile()
		{
			var userId = HttpContext.Session.GetInt32("UserId");
			if (userId == null)
			{
				return RedirectToAction("Login");
			}

			var user = _context.Users.Find(userId);
			if (user == null)
			{
				return NotFound();
			}

			return View(user);
		}

		// POST: Account/Profile (Update Profile)
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Profile(User updatedUser)
		{
			var userId = HttpContext.Session.GetInt32("UserId");
			if (userId == null || userId != updatedUser.Id)
			{
				return RedirectToAction("Login");
			}

			if (ModelState.IsValid)
			{
				_context.Users.Update(updatedUser);
				_context.SaveChanges();
				TempData["SuccessMessage"] = "Profile updated successfully.";
				return RedirectToAction("Profile");
			}

			return View(updatedUser);
		}
	}
}
