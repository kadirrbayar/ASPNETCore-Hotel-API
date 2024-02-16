using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.ServiceDto;

namespace WebUI.Views.ViewComponents.Dashboard
{
    public class _dashboardWidgets : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _dashboardWidgets(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Dashboard/BookingCount");
            if (responseMessage.IsSuccessStatusCode)
                ViewBag.bookingCount = await responseMessage.Content.ReadAsStringAsync();
            var responseMessage2 = await client.GetAsync("https://localhost:7233/api/Dashboard/StaffCount");
            if (responseMessage2.IsSuccessStatusCode)
                ViewBag.staffCount = await responseMessage2.Content.ReadAsStringAsync(); 
            var responseMessage3 = await client.GetAsync("https://localhost:7233/api/Dashboard/UserCount");
            if(responseMessage3.IsSuccessStatusCode)
                ViewBag.userCount = await responseMessage3.Content.ReadAsStringAsync();
            var responseMessage4 = await client.GetAsync("https://localhost:7233/api/Dashboard/RoomCount");
            if(responseMessage4.IsSuccessStatusCode)
                ViewBag.roomCount = await responseMessage4.Content.ReadAsStringAsync();
            return View();
        }
    }
}
