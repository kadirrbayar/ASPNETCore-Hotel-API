using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.TutorialDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        private readonly ITutorialService _tutorialService;
        private readonly IMapper _mapper;

        public TutorialController(ITutorialService tutorialService, IMapper mapper)
        {
            _tutorialService = tutorialService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddTutorial(CreateTutorialDto createTutorialDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Tutorial>(createTutorialDto);
            _tutorialService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTutorial(UpdateTutorialDto updateTutorialDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var values = _mapper.Map<Tutorial>(updateTutorialDto);
            _tutorialService.TUpdate(values);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTutorial(int id)
        {
            var values = _tutorialService.TGetId(id);
            _tutorialService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListTutorial()
        {
            var values = _tutorialService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetTutorial(int id)
        {
            var find = _tutorialService.TGetId(id);
            return Ok(find);
        }
    }
}
