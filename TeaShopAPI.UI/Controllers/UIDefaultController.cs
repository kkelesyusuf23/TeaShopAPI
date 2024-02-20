using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace TeaShopAPI.UI.Controllers
{
    public class UIDefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UIDefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

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
