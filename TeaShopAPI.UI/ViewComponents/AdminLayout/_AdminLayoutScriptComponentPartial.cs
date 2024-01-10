using Microsoft.AspNetCore.Mvc;

namespace TeaShopAPI.UI.ViewComponents.AdminLayout
{
	public class _AdminLayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
