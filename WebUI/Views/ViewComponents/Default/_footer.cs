using Microsoft.AspNetCore.Mvc;

namespace WebUI.Views.ViewComponents.Default
{
    public class _footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
