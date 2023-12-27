using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.SubscribeDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;
        private readonly IMapper _mapper;

        public SubscribeController(ISubscribeService subscribeService, IMapper mapper)
        {
            _subscribeService = subscribeService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddSubscribe(CreateSubscribeDto createSubscribe)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Subscribe>(createSubscribe);
            _subscribeService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(UpdateSubscribeDto updateSubscribe)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Subscribe>(updateSubscribe);
            _subscribeService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetId(id);
            _subscribeService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListSubscribe()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var find = _subscribeService.TGetId(id);
            return Ok(find);
        }
    }
}
