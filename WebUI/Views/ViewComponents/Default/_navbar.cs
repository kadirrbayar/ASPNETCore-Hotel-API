using Microsoft.AspNetCore.Mvc;

namespace WebUI.Views.ViewComponents.Default
{
    public class _navbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
