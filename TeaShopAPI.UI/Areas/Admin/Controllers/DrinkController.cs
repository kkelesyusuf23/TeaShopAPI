using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopAPI.UI.Dtos.DrinkDtos;

namespace TeaShopAPI.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DrinkController : Controller
	{
		private readonly IHttpClientFactory _httpClientfactory;

		public DrinkController(IHttpClientFactory httpClientfactory)
		{
			_httpClientfactory = httpClientfactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientfactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7272/api/Drinks");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultDrinkDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
