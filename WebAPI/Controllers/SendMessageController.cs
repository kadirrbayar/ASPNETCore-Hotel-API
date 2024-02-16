using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.SendMessageDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;
        private readonly IMapper _mapper;

        public SendMessageController(ISendMessageService sendMessageService, IMapper mapper)
        {
            _sendMessageService = sendMessageService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddSendMessage(CreateSendMessageDto createSendMessageDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<SendMessage>(createSendMessageDto);
            _sendMessageService.TInsert(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _sendMessageService.TGetId(id);
            _sendMessageService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListSendMessage()
        {
            var values = _sendMessageService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var find = _sendMessageService.TGetId(id);
            return Ok(find);
        }
    }
}
