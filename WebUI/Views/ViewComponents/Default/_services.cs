using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.ServiceDto;

namespace WebUI.Views.ViewComponents.Default
{
    public class _services : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _services(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ServiceDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
