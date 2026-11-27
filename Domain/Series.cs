using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Series: MediaContent
    {
        public ICollection<Season> Seasons { get; set; } = [];
    }
}
