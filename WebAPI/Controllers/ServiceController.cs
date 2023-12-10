using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TInsert(service);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(int id)
        {
            var find = _serviceService.TGetId(id);
            _serviceService.TUpdate(find);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var find = _serviceService.TGetId(id);
            _serviceService.TDelete(find);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListService()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var find = _serviceService.TGetId(id);
            return Ok(find);
        }
    }
}
