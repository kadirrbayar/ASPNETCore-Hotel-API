using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using WebUI.Dtos.ContactDto;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.SendMessageDto;

namespace WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ContactDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> Sendbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7233/api/SendMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SendMessageDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateSendMessageDto createSendMessageDto)
        {
            if (!ModelState.IsValid)
                return View();
            createSendMessageDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            createSendMessageDto.SenderMail = "aslankral216@gmail.com";
            createSendMessageDto.SenderName = "Admin";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSendMessageDto);
            StringContent content = new(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7233/api/SendMessage", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                //Mail Gönderme işlemleri yapılıyor.
                MimeMessage mimeMessage = new MimeMessage();
                MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "aslankral216@gmail.com");
                mimeMessage.From.Add(mailboxAddressFrom);          
                MailboxAddress mailboxAddressTo = new MailboxAddress(createSendMessageDto.ReceiverName, createSendMessageDto.ReceiverMail);
                mimeMessage.To.Add(mailboxAddressFrom);            
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = createSendMessageDto.Message;
                mimeMessage.Body = bodyBuilder.ToMessageBody();
                mimeMessage.Subject = createSendMessageDto.Subject;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 587, false);
                smtpClient.Authenticate("mail", "pass");
                smtpClient.Send(mimeMessage);
                smtpClient.Disconnect(true);

                return RedirectToAction("Sendbox", "AdminContact");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> InboxMessageDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7233/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ContactDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SendboxMessageDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7233/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<SendMessageDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
