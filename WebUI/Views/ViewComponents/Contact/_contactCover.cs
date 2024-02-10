using Microsoft.AspNetCore.Mvc;

namespace WebUI.Views.ViewComponents.Contact
{
    public class _contactCover:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
