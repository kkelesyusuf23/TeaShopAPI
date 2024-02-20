using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.EntityLayer.Concrete;
using TeaShopAPI.UI.Dtos.RegisterDtos;

namespace TeaShopAPI.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            var appUser = new AppUser()
            {
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.UserName
            };
            var result = await _userManager.CreateAsync(appUser, registerViewModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
