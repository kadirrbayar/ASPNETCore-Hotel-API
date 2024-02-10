using Microsoft.AspNetCore.Mvc;

namespace WebUI.Views.ViewComponents.Default
{
    public class _spinner : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
