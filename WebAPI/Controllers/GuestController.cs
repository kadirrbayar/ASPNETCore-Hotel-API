using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.GuestDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;

        public GuestController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddGuest(CreateGuestDto createGuestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Guest>(createGuestDto);
            _guestService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(UpdateGuestDto updateGuestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Guest>(updateGuestDto);
            _guestService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.TGetId(id);
            _guestService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListGuest()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var find = _guestService.TGetId(id);
            return Ok(find);
        }
    }
}
