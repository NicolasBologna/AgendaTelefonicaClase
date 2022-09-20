using Agenda.API.Entities;

namespace Agenda.API.DTOs
{
    public class UserForUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? LastName { get; set; }
        public string Password { get; set; }
    }
}
