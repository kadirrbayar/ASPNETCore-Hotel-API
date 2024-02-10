using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Dtos.LoginDto;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<DbUser> _signInManager;

        public LoginController(SignInManager<DbUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Index(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginDto.Username, loginDto.Password,false,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Staff");
                }
                return View();
                   
            }
            return View();
        }
    }
}
