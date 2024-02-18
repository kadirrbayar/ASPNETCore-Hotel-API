using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebUI.Dtos.RoomDto;
using WebUI.Models;

namespace WebUI.Views.ViewComponents.Dashboard
{
    public class _dashboardSocialMedia:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram130.p.rapidapi.com/account-info?username=kadirrbayar"),
                Headers =
                {
                    { "X-RapidAPI-Key", "your api key" },
                    { "X-RapidAPI-Host", "instagram130.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<InstagramApiViewModel>(body);
                    ViewBag.v1 = values.edge_followed_by.count;
                    ViewBag.v2 = values.edge_follow.count;
                    ViewBag.v3 = values.username;
                }
            }
            return View();
        }
    }
}
