using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Episode
    {
        public int Id { get; set; }
        public int EpisodeNumber { get; set; }
        public string? Name { get; set; }
        public string? EpisodeVideoUrl { get; set; }
        public Season Season { get; set; } = null!;
        public int SeasonId { get; set; }
    }
}
