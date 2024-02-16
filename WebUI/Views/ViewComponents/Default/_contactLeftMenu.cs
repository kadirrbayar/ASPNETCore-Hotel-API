using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebUI.Dtos.AboutDto;
using WebUI.Models;

namespace WebUI.Views.ViewComponents.Default
{
    public class _contactLeftMenu:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _contactLeftMenu(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Contact/InboxCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var responseMessage2 = await client.GetAsync("https://localhost:7233/api/Contact/SendBoxCount");
                if (responseMessage2.IsSuccessStatusCode)
                {
                    var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                    ViewBag.v1 = jsonData;
                    ViewBag.v2 = jsonData2;
                    return View();
                }
            }
            return View();
        }
    }
}
