using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopAPI.UI.Dtos.QuestionDtos;
using TeaShopAPI.UI.Dtos.TestimonialDtos;

namespace TeaShopAPI.UI.ViewComponents.UIDefault
{
    public class _UIDefaultTestimonialCompanentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UIDefaultTestimonialCompanentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7272/api/Testimonials");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
