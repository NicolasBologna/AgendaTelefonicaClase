﻿using Agenda.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Agenda.API.DTOs
{
    public class UserForUpdateDto
    {
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string? LastName { get; set; }
        public string Password { get; set; }
    }
}
