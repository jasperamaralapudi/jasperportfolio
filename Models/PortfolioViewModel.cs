namespace jasper_portfolio.Models
{
    public class PortfolioViewModel
    {
        public IntroViewModel? Intro { get; set; }
        public EducationViewModel? Education { get; set; }
        public SkillsViewModel? Skills { get; set; }
        public List<ExperienceEntry>? Experiences { get; set; }
        public List<ProjectEntry>? Projects { get; set; }
        public CertificationsViewModel? Certifications { get; set; }
    }
}
