using BusinessLayer.Abstract;
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

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(int id)
        {
            var find = _subscribeService.TGetId(id);
            _subscribeService.TUpdate(find);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var find = _subscribeService.TGetId(id);
            _subscribeService.TDelete(find);
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
