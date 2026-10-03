using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // This is Christopher Antonio D. Pantaleon's portfolio merged into the FINAL EXAM structure.
    // The controller intentionally uses the final-exam project's existing models.
    [Classmate("Pantaleon, Christopher Antonio")]
    public class PantaleonChristopherController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Christopher Antonio D. Pantaleon",

                Tagline = "BS Information Technology Student | IT Elective 2",

                Course = "BS Information Technology",

                Section = "31E3",

                Bio = "Coursework portfolio for IT Elective 2, showcasing activities, projects, examinations, and system development work.",

                PhotoPath = "~/images/christopher.jpg",

                Email = "christopherpantaleon@gmail.com",

                GitHubUrl = "https://github.com/ChristopherPantaleon",

                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "MVC",
                    "Razor",
                    "HTML",
                    "CSS",
                    "JavaScript",
                    "VB.NET",
                    "MySQL",
                    "Git",
                    "GitHub"
                },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "IT Management System",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/ChristopherPantaleon/IT_ELECTIVE_2_MIDTERM_EXAM",

                        Description = "A web-based IT management system designed to manage IT operations, users, services, and other IT-related activities.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML",
                            "CSS"
                        },

                        ImagePath = "~/images/projects/it-management.png"
                    },

                    new ProjectItem
                    {
                        Title = "Student Management System",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/ChristopherPantaleon/IT_ELECTIVE_2_MIDTERM_EXAM",

                        Description = "A student management system designed to organize student information and academic records.",

                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "ASP.NET Core MVC",
                            "SQL"
                        },

                        ImagePath = "~/images/projects/student-management.png"
                    },

                    new ProjectItem
                    {
                        Title = "Vehicle Service Monitoring",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/ChristopherPantaleon/IT_ELECTIVE_2_MIDTERM_EXAM",

                        Description = "A vehicle service monitoring system for tracking customer information, vehicle details, service jobs, service status, and release information.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "BCrypt"
                        },

                        ImagePath = "~/images/projects/vehicle-service.png"
                    },

                    new ProjectItem
                    {
                        Title = "Eyelottea Restobar POS",

                        Stage = ProjectStage.PreFinal,

                        RepoUrl = "https://github.com/ChristopherPantaleon/IT_ELECTIVE_2_MIDTERM_EXAM",

                        Description = "A VB.NET Windows Forms POS and inventory system designed to manage orders, transactions, payments, and inventory.",

                        TechStack = new List<string>
                        {
                            "VB.NET",
                            "Windows Forms",
                            "MySQL"
                        },

                        ImagePath = "~/images/projects/eyelottea.png"
                    }
                }
            };

            return View(profile);
        }
    }
}

