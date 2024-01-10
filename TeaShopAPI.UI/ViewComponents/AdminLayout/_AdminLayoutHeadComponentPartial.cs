using Microsoft.AspNetCore.Mvc;

namespace TeaShopAPI.UI.ViewComponents.AdminLayout
{
	public class _AdminLayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
