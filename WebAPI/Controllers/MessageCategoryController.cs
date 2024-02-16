using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.MessageCategoryDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;
        private readonly IMapper _mapper;

        public MessageCategoryController(IMessageCategoryService messageCategoryService, IMapper mapper)
        {
            _messageCategoryService = messageCategoryService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddMessageCategory(CreateMessageCategoryDto createMessageCategoryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<MessageCategory>(createMessageCategoryDto);
            _messageCategoryService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateMessageCategory(UpdateMessageCategoryDto createMessageCategoryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<MessageCategory>(createMessageCategoryDto);
            _messageCategoryService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCategory(int id)
        {
            var values = _messageCategoryService.TGetId(id);
            _messageCategoryService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListMessageCategory()
        {
            var values = _messageCategoryService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetMessageCategory(int id)
        {
            var find = _messageCategoryService.TGetId(id);
            return Ok(find);
        }
    }
}
