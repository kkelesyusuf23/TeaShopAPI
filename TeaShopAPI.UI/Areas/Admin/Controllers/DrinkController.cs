using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using TeaShopAPI.UI.Dtos.DrinkDtos;

namespace TeaShopAPI.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
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

		[HttpGet]
		public IActionResult CreateDrink()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateDrink(CreateDrinkDto createDrinkDto)
		{
			var client = _httpClientfactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createDrinkDto);
			StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
			var responseMessage = await client.PostAsync("https://localhost:7272/api/Drinks", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		public async Task<IActionResult> DeleteDrink(int id)
		{
			var client = _httpClientfactory.CreateClient();
			var responseMessage = await client.DeleteAsync("https://localhost:7272/api/Drinks?id="+id);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
        }

		[HttpGet]
		public async Task<IActionResult> UpdateDrink(int id)
		{
			var client = _httpClientfactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7272/api/Drinks/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateDrinkDto>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateDrink(UpdateDrinkDto updateDrinkDto)
		{
			var client = _httpClientfactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateDrinkDto);
			StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
			var responseMessage = await client.PutAsync("https://localhost:7272/api/Drinks/",content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
