using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopAPI.UI.Dtos.DrinkDtos;

namespace TeaShopAPI.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
	public class DashboardController : Controller
	{
        private readonly IHttpClientFactory _httpClientfactory;

        public DashboardController(IHttpClientFactory httpClientfactory)
        {
            _httpClientfactory = httpClientfactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientfactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7272/api/Statistic/GetDrinkAveragePrice");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.drinkAveragePrice = jsonData;

            var responseMessage1 = await client.GetAsync("https://localhost:7272/api/Statistic/GetDrinkCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.drinkCount = jsonData1;

            var responseMessage2 = await client.GetAsync("https://localhost:7272/api/Statistic/GetLastDrinkName");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.lastDrinkName = jsonData2;

            var responseMessage3 = await client.GetAsync("https://localhost:7272/api/Statistic/GetMaxPriceDrinkName");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.maxPriceDrinkName = jsonData3;

            return View();

        }
    }
}
