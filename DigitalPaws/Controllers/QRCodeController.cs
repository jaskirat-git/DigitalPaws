using Microsoft.AspNetCore.Mvc;

namespace DigitalPaws.Controllers
{
	public class QRCodeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
