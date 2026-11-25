using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ContentReaction
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int MediaContentId { get; set; }
        public MediaContent MediaContent { get; set; } = null!;
        public bool IsLike { get; set; }
    }
}
