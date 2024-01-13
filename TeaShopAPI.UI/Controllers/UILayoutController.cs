using Microsoft.AspNetCore.Mvc;

namespace TeaShopAPI.UI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
