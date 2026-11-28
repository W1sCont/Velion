using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<MediaContent> MediaContents { get; set; } = [];
    }
}
