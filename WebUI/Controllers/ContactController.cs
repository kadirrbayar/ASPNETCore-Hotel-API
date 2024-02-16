using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text;
using WebUI.Dtos.ContactDto;
using WebUI.Dtos.MessageCategoryDto;
using WebUI.Dtos.StaffDto;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var model = await SelectListItem();
            if (model != null)
                ViewBag.v1 = model;
            return View();
        }

        private async Task<List<SelectListItem>?> SelectListItem()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/MessageCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<MessageCategoryDto>>(jsonData);
                List<SelectListItem> selectListItems = (from x in values
                                                        select new SelectListItem
                                                        {
                                                            Text = x.CategoryName,
                                                            Value = x.MessageCategoryId.ToString()
                                                        }).ToList();
                return selectListItems;
            }
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            var model = await SelectListItem();
            if (model != null)
                ViewBag.v1 = model;
            if (!ModelState.IsValid)
                return View("Index", createContactDto);
            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent content = new(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7233/api/Contact", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View("Index", createContactDto);
        }
    }
}
