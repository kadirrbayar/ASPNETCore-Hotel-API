using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebUI.Dtos.BookingDto;
using WebUI.Dtos.StaffDto;

namespace WebUI.Controllers
{
    public class AdminBookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminBookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<BookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task <IActionResult> UpdateApprove(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.PutAsync($"https://localhost:7233/api/Booking/UpdateBookingApprove?id={id}", null);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public async Task <IActionResult> UpdateDecline(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.PutAsync($"https://localhost:7233/api/Booking/UpdateBookingDecline?id={id}", null);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public async Task <IActionResult> UpdateWaiting(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.PutAsync($"https://localhost:7233/api/Booking/UpdateBookingWaiting?id={id}", null);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
