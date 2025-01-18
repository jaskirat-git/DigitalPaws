using Microsoft.AspNetCore.Mvc;

namespace DigitalPaws.Controllers
{
	public class ChatController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
