using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.TestimonialDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddTestimonial(CreateTestimonialDto createTestimonial)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Testimonial>(createTestimonial);
            _testimonialService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonial)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Testimonial>(updateTestimonial);
            _testimonialService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.TGetId(id);
            _testimonialService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListTestimonial()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var find = _testimonialService.TGetId(id);
            return Ok(find);
        }
    }
}
