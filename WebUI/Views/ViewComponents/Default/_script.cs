using Microsoft.AspNetCore.Mvc;

namespace WebUI.Views.ViewComponents.Default
{
    public class _script : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
