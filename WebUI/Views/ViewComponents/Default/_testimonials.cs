using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.TestimonialDto;

namespace WebUI.Views.ViewComponents.Default
{
    public class _testimonials : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _testimonials(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
