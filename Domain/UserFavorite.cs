using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UserFavorite
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int MediaContentId { get; set; }
        public MediaContent MediaContent { get; set; } = null!;
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
}
