using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.StaffDto;

namespace WebUI.Views.ViewComponents.Default
{
    public class _teams : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _teams(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
