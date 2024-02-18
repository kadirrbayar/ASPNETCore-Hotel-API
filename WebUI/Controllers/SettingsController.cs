using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Dtos.DbUserDto;

namespace WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<DbUser> _userManager;
        public SettingsController(UserManager<DbUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity?.Name);
            UpdateDbUserDto updateDbUserDto = new UpdateDbUserDto();
            updateDbUserDto.Name = user.Name;
            updateDbUserDto.Surname = user.Surname;
            updateDbUserDto.Username = user.UserName;
            updateDbUserDto.Id = user.Id;
            updateDbUserDto.Mail = user.Email;
            updateDbUserDto.City = user.City;
            return View(updateDbUserDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UpdateDbUserDto updateDbUserDto)
        {
            if (!ModelState.IsValid)
                return View();
            var user = await _userManager.FindByNameAsync(User.Identity?.Name);
            user.Name = updateDbUserDto.Name;
            user.Surname = updateDbUserDto.Surname;
            user.Email = updateDbUserDto.Mail;
            user.City = updateDbUserDto.City;
            if (updateDbUserDto.CurrentPassword != null && updateDbUserDto.Password != null)
            {
                var success = await _userManager.ChangePasswordAsync(user, updateDbUserDto.CurrentPassword, updateDbUserDto.Password);
                if (success.Succeeded)
                {
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                }
            }
            else
            {
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            return View();
        }
    }
}
