﻿using Microsoft.AspNetCore.Identity;

namespace Jwtauthentication6._0.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}
