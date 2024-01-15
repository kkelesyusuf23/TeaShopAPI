using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopAPI.UI.Dtos.AboutDtos;
using TeaShopAPI.UI.Dtos.OurTeaShopDtos;

namespace TeaShopAPI.UI.ViewComponents.UIDefault
{
    public class _UIDefaultOurTeaShopComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UIDefaultOurTeaShopComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7272/api/OurTeaShops");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultOurTeaShopDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
