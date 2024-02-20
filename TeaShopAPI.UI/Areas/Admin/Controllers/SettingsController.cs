using Microsoft.AspNetCore.Mvc;

namespace TeaShopAPI.UI.Areas.Admin.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
