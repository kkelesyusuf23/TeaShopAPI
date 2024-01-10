using Microsoft.AspNetCore.Mvc;

namespace TeaShopAPI.UI.ViewComponents.AdminLayout
{
	public class _AdminLayoutLoaderAndNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
