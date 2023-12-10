using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(int id)
        {
            var find = _staffService.TGetId(id);
            _staffService.TUpdate(find);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var find = _staffService.TGetId(id);
            _staffService.TDelete(find);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListStaff()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var find = _staffService.TGetId(id);
            return Ok(find);
        }
    }
}
