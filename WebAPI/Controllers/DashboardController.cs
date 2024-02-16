using AutoMapper;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IStaffService _staffService;
        private readonly IRoomService _roomService;
        private readonly IDbUserService _dbUserService;
        private readonly IMapper _mapper;

        public DashboardController(IBookingService bookingService, IStaffService staffService, IMapper mapper, IRoomService roomService, IDbUserService dbUserService)
        {
            _bookingService = bookingService;
            _staffService = staffService;
            _roomService = roomService;
            _mapper = mapper;
            _dbUserService = dbUserService;
        }

        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            return Ok(_bookingService.TBookingCount());
        }

        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            return Ok(_staffService.TStaffCount());
        }
        
        [HttpGet("RoomCount")]
        public IActionResult RoomCount()
        {
            return Ok(_roomService.TRoomCount());
        }

        [HttpGet("UserCount")]
        public IActionResult UserCount()
        {
            return Ok(_dbUserService.TDbUserCount());
        }
        
        [HttpGet("Last4Staff")]
        public IActionResult Last4Staff()
        {
            return Ok(_staffService.TLast4Staff());
        }
        
        [HttpGet("Last6Booking")]
        public IActionResult Last6Booking()
        {
            return Ok(_bookingService.TLast6Booking());
        }
    }
}
