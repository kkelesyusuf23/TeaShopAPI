using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopAPI.UI.Dtos.DrinkDtos;
using TeaShopAPI.UI.Dtos.SliderDtos;

namespace TeaShopAPI.UI.ViewComponents.UILayout
{
	public class _UILayoutSliderComponentPartial:ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public _UILayoutSliderComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7272/api/Sliders");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
