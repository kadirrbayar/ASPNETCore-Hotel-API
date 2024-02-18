using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace WebUI.Controllers
{
    public class AdminFileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file)
        {
            var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            var bytes = stream.ToArray();
            ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent
            {
                { byteArrayContent, "file", file.FileName }
            };
            var httpclient = new HttpClient();
            await httpclient.PostAsync("https://localhost:7233/api/File", multipartFormDataContent);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
