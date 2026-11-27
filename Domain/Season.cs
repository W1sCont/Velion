using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Season
    {
        public int Id { get; set; }
        public int SeasonNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Episode> Episodes { get; set; } = [];
        public MediaContent MediaContent { get; set; } = null!;
        public int MediaContentId { get; set; }
    }
}
