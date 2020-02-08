using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DateMatchApp.API.Data;
using DateMatchApp.API.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DateMatchApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IDateMatchRepository _repo;
        private readonly IMapper _mapper;
        public UsersController(IDateMatchRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _repo.GetUsers();
            var userReturn = _mapper.Map<IEnumerable<UserForListDto>>(users);

            return Ok(userReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);
            var userReturn = _mapper.Map<UserForDetailedDto>(user);

            return Ok(userReturn);
        }
    }
}