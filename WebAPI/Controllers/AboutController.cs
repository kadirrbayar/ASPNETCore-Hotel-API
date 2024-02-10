using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.AboutDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;
        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddRoom(CreateAboutDto createAbout)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<About>(createAbout);
            _aboutService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAbout)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<About>(updateAbout);
            _aboutService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetId(id);
            _aboutService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListAbout()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var find = _aboutService.TGetId(id);
            return Ok(find);
        }
    }
}
