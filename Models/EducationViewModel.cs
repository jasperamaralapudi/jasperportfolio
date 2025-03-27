using System.Collections.Generic;

namespace jasper_portfolio.Models
{
    public class EducationViewModel
    {
        public string? University { get; set; }
        public string? Degree { get; set; }
        public double CGPA { get; set; }
        public List<string>? CourseWork { get; set; }
    }
}
