using Microsoft.AspNetCore.Mvc;

namespace WebUI.Views.ViewComponents.Default
{
    public class _slide : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
