using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.BookingDto;
using WebUI.Dtos.StaffDto;

namespace WebUI.Views.ViewComponents.Dashboard
{
    public class _dashboardReservation:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _dashboardReservation(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Dashboard/Last6Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last6BookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
