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

        public User? GetUserById(int id)
        {
            return FakeUsers.SingleOrDefault(x => x.Id == id);
        }

        public void CreateUser(User newUser)
        {
            FakeUsers.Add(newUser);
        }

        public int GetLastId()
        {
            return FakeUsers.Last().Id;
        }

        public void UpdateUser(User user)
        {
            var fakeUser = FakeUsers.SingleOrDefault(x => x.Id == user.Id);
            fakeUser.Name = user.Name;
            fakeUser.LastName = user.LastName;
            fakeUser.Email = user.Email;
            fakeUser.Password = user.Password;
        }
    }
}