using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Dtos.RoleDto;
using WebUI.Views.ViewComponents.Default;

namespace WebUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<DbRole> _roleManager;
        public RoleController(RoleManager<DbRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(CreateRoleDto createRoleDto)
        {
            DbRole roleDto = new DbRole()
            {
                Name = createRoleDto.RoleName
            };
            var result = await _roleManager.CreateAsync(roleDto);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult EditRole(int id)
        {
            var result = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            if(result != null)
            {
                UpdateRoleDto updateRoleDto = new UpdateRoleDto()
                {
                    Id = result.Id,
                    RoleName = result.Name
                };
                return View(updateRoleDto);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(UpdateRoleDto updateRoleDto)
        {
            var find = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleDto.Id);
            if (find != null)
            {
                find.Name = updateRoleDto.RoleName;
                await _roleManager.UpdateAsync(find);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult DeleteRole(int id)
        {
            var result = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                _roleManager.DeleteAsync(result);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
