using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.ServiceDto;
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
        private readonly IMapper _mapper;

        public ServiceController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddService(CreateServiceDto createService)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Service>(createService);
            _serviceService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(UpdateServiceDto updateService)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Service>(updateService);
            _serviceService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetId(id);
            _serviceService.TDelete(values);
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
