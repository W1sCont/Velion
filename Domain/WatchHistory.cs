using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class WatchHistory
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int MediaContentId { get; set; }
        public MediaContent MediaContent { get; set; } = null!;
        public int? EpisodeId { get; set; }
        public Episode? Episode { get; set; }
        public DateTime WatchedAt { get; set; } = DateTime.UtcNow;
    }
}
