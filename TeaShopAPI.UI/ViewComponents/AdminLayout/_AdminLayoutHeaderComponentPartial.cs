using Microsoft.AspNetCore.Mvc;

namespace TeaShopAPI.UI.ViewComponents.AdminLayout
{
	public class _AdminLayoutHeaderComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
