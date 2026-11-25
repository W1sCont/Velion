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
        public string? Avatar { get; set; } 
        public RoleType Role { get; set; } = RoleType.Viewer;
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
        public ICollection<UserFavorite> Favorites { get; set; } = [];
    }
}
