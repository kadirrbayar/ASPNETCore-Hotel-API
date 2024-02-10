using Microsoft.AspNetCore.Mvc;
using WebUI.Dtos.SubscribeDto;

namespace WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SubscribeResult()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeResult(CreateSubscribeDto createSubscribeDto)
        {
            return PartialView();
        }

    }
}
