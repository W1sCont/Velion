using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enum;

namespace Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string HashPassword { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public RoleTypes Role { get; set; } = RoleTypes.User;
        public DateTime Register { get; set; } = DateTime.UtcNow;
    }
}
