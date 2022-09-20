using Agenda.API.DTOs;
using Agenda.API.Entities;

namespace Agenda.API.Repository
{
    public class UserRepository
    {
        static List<User> FakeUsers = new List<User>()
            {
                new User()
                {
                    Email = "a@asdasd.com",
                    Name = "Pablo",
                    Password = "passwordresegura",
                    Id = 1,
                },
                new User()
                {
                    Email = "b@asdasd.com",
                    Name = "Mateo",
                    Password = "passwordresegura1",
                    Id = 2,
                }
            };

        public List<User> GetAllUsers()
        {
            return FakeUsers;
        }

        public bool CreateUser(UserForCreationDTO userDTO)
        {
            User user = new User()
            {
                Name = userDTO.Name,
                Password = userDTO.Password,
                Id = userDTO.Id,
                Email = userDTO.Email,
            };
            FakeUsers.Add(user);
            return true;
        }
    }
}