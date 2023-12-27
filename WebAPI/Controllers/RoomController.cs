using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.RoomDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddRoom(CreateRoomDto createRoom)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Room>(createRoom);
            _roomService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoom)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Room>(updateRoom);
            _roomService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetId(id);
            _roomService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListRoom()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var find = _roomService.TGetId(id);
            return Ok(find);
        }
    }
}
