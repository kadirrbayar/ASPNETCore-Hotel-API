using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.BookingDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddBooking(CreateBookingDto createBookingDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Booking>(createBookingDto);
            _bookingService.TInsert(values);
            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Booking>(updateBookingDto);
            _bookingService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetId(id);
            _bookingService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListBooking()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var find = _bookingService.TGetId(id);
            return Ok(find);
        }

        [HttpPut("UpdateBookingApprove")]
        public IActionResult UpdateBookingApprove(int id)
        {
            _bookingService.TUpdateBookingApprove(id);
            return Ok();
        }

        [HttpPut("UpdateBookingDecline")]
        public IActionResult UpdateBookingDecline(int id)
        {
            _bookingService.TUpdateBookingDecline(id);
            return Ok();
        }

        [HttpPut("UpdateBookingWaiting")]
        public IActionResult UpdateBookingWaiting(int id)
        {
            _bookingService.TUpdateBookingWaiting(id);
            return Ok();
        }
    }
}
