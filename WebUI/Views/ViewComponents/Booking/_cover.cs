using Microsoft.AspNetCore.Mvc;

namespace WebUI.Views.ViewComponents.Booking
{
    public class _cover:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
