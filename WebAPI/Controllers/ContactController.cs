using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.ContactDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddContact(CreateContactDto createContact)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Contact>(createContact);
            _contactService.TInsert(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetId(id);
            _contactService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListContact()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var find = _contactService.TGetId(id);
            return Ok(find);
        }

        [HttpGet("InboxCount")]
        public IActionResult InboxCount()
        {
            return Ok(_contactService.TInboxCount());
        }
        
        [HttpGet("SendBoxCount")]
        public IActionResult SendBoxCount()
        {
            return Ok(_contactService.TSendBoxCount());
        }
    }
}
