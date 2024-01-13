using Microsoft.AspNetCore.Mvc;

namespace TeaShopAPI.UI.Controllers
{
    public class UIDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
