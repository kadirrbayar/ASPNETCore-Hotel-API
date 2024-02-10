using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.AboutDto;
using WebUI.Dtos.RoomDto;

namespace WebUI.Views.ViewComponents.Default
{
    public class _rooms : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _rooms(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<RoomDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
