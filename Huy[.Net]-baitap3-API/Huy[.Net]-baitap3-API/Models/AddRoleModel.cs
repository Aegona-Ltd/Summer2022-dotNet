﻿using System.ComponentModel.DataAnnotations;

namespace Huy_.Net__baitap3_API.Models
{
    public class AddRoleModel
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Role { get; set; }
    }
}
