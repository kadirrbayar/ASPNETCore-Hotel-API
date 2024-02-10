using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.TutorialDto;

namespace WebUI.Views.ViewComponents.Default
{
    public class _tutorial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _tutorial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Tutorial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TutorialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
