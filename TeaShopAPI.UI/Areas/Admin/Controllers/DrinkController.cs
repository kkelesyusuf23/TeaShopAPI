using Microsoft.AspNetCore.Mvc;

namespace TeaShopAPI.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DrinkController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
