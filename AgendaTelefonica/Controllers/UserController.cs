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
            var users = _userRepository.GetAllUsers();
            List<UserDto> usersDto = new List<UserDto>();
            foreach (var user in users)
            {
                var userDto = new UserDto()
                {
                    Id = user.Id,
                    Email = user.Email,
                    LastName = user.LastName,
                    Name = user.Name
                };
                usersDto.Add(userDto);
            }
            return Ok(usersDto);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetOneById(int id)
        {
            var user = _userRepository.GetUserById(id);

            if (user is null)
                return NotFound("Usuario inexistente");
            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser(UserForCreationDTO userDto)
        {
            var lastId = _userRepository.GetLastId();

            User user = new User()
            {
                Name = userDto.Name,
                Password = userDto.Password,
                Id = lastId + 1,
                Email = userDto.Email,
            };
            _userRepository.CreateUser(user);
            return NoContent();
        }

        [HttpPut]
        public IActionResult Update(UserForUpdateDto userDto)
        {
            User user = new User()
            {
                Name = userDto.Name,
                Password = userDto.Password,
                Id = userDto.Id,
                Email = userDto.Email,
            };
            _userRepository.UpdateUser(user);
            return NoContent();
        }
    }
}