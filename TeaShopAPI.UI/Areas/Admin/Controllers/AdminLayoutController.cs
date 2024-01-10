﻿using Microsoft.AspNetCore.Mvc;

namespace TeaShopAPI.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
