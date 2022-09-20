﻿using System.ComponentModel.DataAnnotations;

namespace Agenda.API.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? LastName { get; set; }
    }
}
