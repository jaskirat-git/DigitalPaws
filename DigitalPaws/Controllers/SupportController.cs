using Microsoft.AspNetCore.Mvc;

namespace DigitalPaws.Controllers
{
	public class SupportController : Controller
	{
		public IActionResult ContactSupport()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SubmitSupportRequest(string FullName, string Email, string Subject, string Message)
		{
			if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Subject) || string.IsNullOrEmpty(Message))
			{
				TempData["SuccessMessage"] = "Please fill in all fields.";
				return RedirectToAction("ContactSupport");
			}

			// Simulate sending support request (replace with actual email sending later)
			TempData["SuccessMessage"] = "Your support request has been submitted successfully!";
			return RedirectToAction("ContactSupport");
		}
	}
}
