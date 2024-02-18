using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.DbUserDto;
using WebUI.Dtos.RoleDto;

namespace WebUI.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly RoleManager<DbRole> _roleManager;
        private readonly UserManager<DbUser> _userManager;
        public RoleAssignController(RoleManager<DbRole> roleManager, UserManager<DbUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var result = _userManager.Users.ToList();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> RoleAdd(int id)
        {
            var find = _userManager.Users.FirstOrDefault(x => x.Id == id);
            if (find != null)
            {
                var roles = _roleManager.Roles.ToList();
                var result = await _userManager.GetRolesAsync(find);
                List<RoleAssignDto> roleAssignDtos = new List<RoleAssignDto>();
                foreach (var role in roles)
                {
                    RoleAssignDto roleAssignDto = new RoleAssignDto();
                    roleAssignDto.Id = role.Id;
                    roleAssignDto.RoleName = role.Name;
                    roleAssignDto.Exist = result.Contains(role.Name);
                    roleAssignDto.UserId = find.Id;
                    roleAssignDtos.Add(roleAssignDto);
                }
                return View(roleAssignDtos);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleAdd(List<RoleAssignDto> roleAssignDto)
        {
            var userId = roleAssignDto.Select(x => x.UserId).FirstOrDefault();
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);
            if (user != null)
            {
                foreach (var x in roleAssignDto)
                {
                    if (x.Exist)
                    {
                        await _userManager.AddToRoleAsync(user, x.RoleName);
                    }
                    else
                    {
                        await _userManager.RemoveFromRoleAsync(user, x.RoleName);
                    }
                }
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
