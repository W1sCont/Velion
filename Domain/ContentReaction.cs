using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ContentReaction
    {
        public int Id { get; set; }
        public User UserId { get; set; } = null!;
        public MediaContent MediaContentId { get; set; } = null!;
        public Boolean IsLike { get; set; }
    }
}
