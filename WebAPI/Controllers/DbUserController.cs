using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbUserController : ControllerBase
    {
        private readonly IDbUserService _dbUserService;
        private readonly IMapper _mapper;

        public DbUserController(IDbUserService dbUserService, IMapper mapper)
        {
            _dbUserService = dbUserService;
            _mapper = mapper;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDbUser(int id)
        {
            var values = _dbUserService.TGetId(id);
            _dbUserService.TDelete(values);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListDbUser()
        {
            var values = _dbUserService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetDbUser(int id)
        {
            var find = _dbUserService.TGetId(id);
            return Ok(find);
        }

    }
}
