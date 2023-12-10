using BusinessLayer.Abstract;
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

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(int id)
        {
            var find = _testimonialService.TGetId(id);
            _testimonialService.TUpdate(find);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var find = _testimonialService.TGetId(id);
            _testimonialService.TDelete(find);
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
