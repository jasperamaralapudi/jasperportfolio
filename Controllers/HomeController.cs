using jasper_portfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace jasper_portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var portfolio = new PortfolioViewModel
            {
                Intro = new IntroViewModel
                {
                    Name = "Jasper Enoch",
                    Title = "Software Engineer | .NET Developer | Data Science Enthusiast",
                    ProfileImagePath = "/img/profile.jpg",
                    LinkedInUrl = "https://www.linkedin.com/in/jasper-amarlapudi",
                    GitHubUrl = "https://github.com/jasperamaralapudi",
                    Email = "jasperenoch0@gmail.com"
                },
                Education = new EducationViewModel
                {
                    University = "SR University",
                    Degree = "BTech",
                    CGPA = 8.8,
                    CourseWork = new List<string>
                    {
                        "DATA structures",
                        "Design Analysis of Algorithms",
                        "Operating Systems",
                        "Database Management Systems",
                        "Computer Networks"
                    }
                },
                Skills = new SkillsViewModel
                {
                    Languages = new List<string> { "C", "Python", "Java" },
                    WebTechnologies = new List<string> { "ASP.NET MVC Architecture" },
                    DatabaseSystems = new List<string> { "PLSQL", "SQL" },
                    DataScienceML = new List<string> { "NumPy", "Data Science", "Machine Learning" },
                    CloudTechnologies = new List<string> { "AWS" },
                    SpecializedArea = new List<string> { "Data Science", "Machine Learning" },
                    OtherToolsTechnologies = new List<string> { "Visual Studio Code", "Visual Studio 2022" }
                },
                Experiences = new List<ExperienceEntry>
                {
                    new ExperienceEntry
                    {
                        Company = "Nowcom Global Services India",
                       
                        Position = "Software Engineer Intern",
                        Duration = " June 2024 - July 2024",
                        Location = "Greater Hyderabad Area, India",
                        BulletPoints = new List<string>
                        {
                            "Completed one week of intensive training in C# programming, covering both fundamentals and advanced topics.",
                            "Received one week of comprehensive training on Object-Oriented Programming (OOP) concepts in C#, enhancing knowledge of software design principles.",
                            "Documented and developed a Unit Converter System using MVC Architecture, applying theoretical knowledge to practical problem solving."
                        }
                    },
                    new ExperienceEntry
                    {
                        Company = "Coratia Private Limited (in collaboration with TeachNook)",
                        
                        Position = "Data Science Intern",
                        Duration = "September 2022 - October 2022",
                        Location = "Remote",
                        BulletPoints = new List<string>
                        {
                            "Developed a customer churn prediction model for a telecom company using Python, preprocessing data and experimenting with machine learning algorithms like Random Forest, XGBoost, and LightGBM.",
                            "Evaluated model performance using accuracy, precision, recall, F1 score, ROC AUC, and confusion matrix, providing actionable insights for reducing customer churn and improving efficiency by 20%.",
                            "Documented the entire project, including data exploration, preprocessing, model selection, evaluation metrics, analysis, and business insights."
                        }
                    }
                },
                Projects = new List<ProjectEntry>
                {
                    new ProjectEntry
                    {
                        Title = "UNIT CONVERTER SYSTEM IN C",
                        BulletPoints = new List<string>
                        {
                            "Developed a unit converter system in C for temperature, mass, currency, and length conversions that is user-friendly.",
                            "Implemented accurate conversion formulas and calculations across multiple categories.",
                            "Collaborated effectively in a team environment, utilizing version control and communication."
                        }
                    },
                    new ProjectEntry
                    {
                        Title = "Deployment of Optimized Model for Fraud Detection",
                        BulletPoints = new List<string>
                        {
                            "Developed a fraud detection model using machine learning techniques like Random Forest, XGBoost, and ensemble methods on imbalanced payment transactions.",
                            "Performed data preprocessing, handling imbalanced data, feature engineering, model training, and evaluation using metrics such as confusion matrix, classification report, and ROC-AUC curve.",
                            "Collaborated effectively in a team environment, utilizing version control and communication."
                        }
                    }
                },
                Certifications = new CertificationsViewModel
                {
                    Certifications = new List<string>
                    {
                        "Introduction to AI and Machine Learning on Google Cloud by Google",
                        "Introduction to Artificial Intelligence by IBM"
                    }
                },

            };


            return View(portfolio);
        }
        public IActionResult Contact()
        {
            return View(new ContactViewModel());
        }

        // POST: /Home/Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // TODO: Implement email sending or database storage for the message.
                TempData["SuccessMessage"] = "Thank you for your message! I will get back to you soon.";
                return RedirectToAction("Contact");
            }
            return View(model);
        }
    }
}
