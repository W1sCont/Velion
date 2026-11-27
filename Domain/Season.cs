using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Season
    {
        public int Id { get; set; }
        public int SeasonNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Episode> Episodes { get; set; } = [];
        public Series Series { get; set; } = null!;
        public int SeriesId { get; set; }
    }
}
