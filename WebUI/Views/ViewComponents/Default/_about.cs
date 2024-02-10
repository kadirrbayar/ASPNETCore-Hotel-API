using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using WebUI.Dtos.AboutDto;
using WebUI.Dtos.StaffDto;

namespace WebUI.Views.ViewComponents.Default
{
    public class _about : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _about(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AboutDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
