using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UserFavorite
    {
        public int Id { get; set; }
        public User UserId { get; set; } = null!;
        public MediaContent MediaContentId { get; set; } = null!;
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
}
