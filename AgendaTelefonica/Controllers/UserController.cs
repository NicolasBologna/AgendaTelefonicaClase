using Agenda.API.DTOs;
using Agenda.API.Entities;
using Agenda.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userRepository.GetAllUsers());
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetOneById(int Id)
        {
            List<User> usersToReturn = _userRepository.GetAllUsers();
            usersToReturn.Where(x => x.Id == Id).ToList();
            if (usersToReturn.Count > 0)
                return Ok(usersToReturn);
            return NotFound("Usuario inexistente");
        }

        [HttpPost]
        public IActionResult CreateUser(UserForCreationDTO userDTO)
        {
            _userRepository.CreateUser(userDTO);
            return NoContent();
        }

    }
}