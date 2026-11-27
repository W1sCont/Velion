using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public enum MovieOrSeries
    {
        Movie = 1,
        Series = 2
    }
    public class MediaContent
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string Poster {  get; set; } = string.Empty;
        public string? Trailer { get; set; }
        public Genre Genre { get; set; } = null!;
        public int GenreId { get; set; }
        public MovieOrSeries ContentType { get; set; }
        public string? FullVideoUrl { get; set; }
        public bool IsAvailable {  get; set; }
    }
}
