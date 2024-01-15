using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopAPI.UI.Dtos.OurTeaShopDtos;
using TeaShopAPI.UI.Dtos.QuestionDtos;

namespace TeaShopAPI.UI.ViewComponents.UIDefault
{
    public class _UIDefaultQuestionsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UIDefaultQuestionsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7272/api/Questions");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultQuestionDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
