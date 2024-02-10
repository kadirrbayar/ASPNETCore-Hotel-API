using Microsoft.AspNetCore.Mvc;

namespace WebUI.Views.ViewComponents.Default
{
    public class _head:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
