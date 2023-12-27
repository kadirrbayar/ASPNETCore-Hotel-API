using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.StaffDto;
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
        private readonly IMapper _mapper;

        public StaffController(IStaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddStaff(CreateStaffDto createStaff)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Staff>(createStaff);
            _staffService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(UpdateStaffDto updateStaff)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Staff>(updateStaff);
            _staffService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetId(id);
            _staffService.TDelete(values);
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
