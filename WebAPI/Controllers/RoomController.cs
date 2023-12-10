using BusinessLayer.Abstract;
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

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.TInsert(room);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(int id)
        {
            var find = _roomService.TGetId(id);
            _roomService.TUpdate(find);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var find = _roomService.TGetId(id);
            _roomService.TDelete(find);
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
