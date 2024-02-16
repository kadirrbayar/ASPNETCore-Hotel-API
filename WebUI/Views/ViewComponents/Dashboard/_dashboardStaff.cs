using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.StaffDto;

namespace WebUI.Views.ViewComponents.Dashboard
{
    public class _dashboardStaff:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _dashboardStaff(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Dashboard/Last4Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last4StaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
