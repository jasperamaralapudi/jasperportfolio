using System.Collections.Generic;

namespace jasper_portfolio.Models
{
    public class ExperienceEntry
    {
        public string? Company { get; set; }
        public string? Validation { get; set; } // e.g., "validate"
        public string? Position { get; set; }
        public string? Duration { get; set; }
        public string? Location { get; set; }
        public List<string>? BulletPoints { get; set; }
    }
}
