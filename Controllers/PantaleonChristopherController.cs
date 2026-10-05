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

                GitHubUrl = "https://github.com/Chant-prog",

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
                        Title = "IT Elective 2 Prefinal Exam",

                        Stage = ProjectStage.PreFinal,

                        RepoUrl = "https://github.com/Chant-prog/IT_ELECTIVE_2_-BSIT-31E3-_PREFINAL_EXAM_Pantaleon_Christopher.git",

                        Description = "Prefinal examination project for IT Elective 2.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML",
                            "CSS"
                        },

                        ImagePath = "~/images/projects/prefinal-exam.png"
                    },

                    new ProjectItem
                    {
                        Title = "Pet Grooming Appointment System",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/Chant-prog/IT_ELECTIVE_2_MIDTERM_EXAM_Pet-Grooming-Appointment_Pantaleon_ChristopherAntonio.git",

                        Description = "A pet grooming appointment system designed to manage appointments, customer details, and pet service schedules.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML",
                            "CSS"
                        },

                        ImagePath = "~/images/projects/pet-grooming.png"
                    },

                    new ProjectItem
                    {
                        Title = "Modern Portfolio Quiz",

                        Stage = ProjectStage.Midterm,

                        RepoUrl = "https://github.com/Chant-prog/Quiz_BSIT31E3_Pantaleon_Christopher_ModernPortfolio.git",

                        Description = "A modern portfolio quiz web application for IT Elective 2.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML",
                            "CSS"
                        },

                        ImagePath = "~/images/projects/modern-portfolio.png"
                    },

                    new ProjectItem
                    {
                        Title = "BSIT 31E3 Prelim Assignment 1",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/Chant-prog/BSIT31E3_PRELIM_A1_Pantaleon_ChristopherAntonio.git",

                        Description = "Prelim Assignment 1 coursework project.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC"
                        },

                        ImagePath = "~/images/projects/prelim-a1.png"
                    },

                    new ProjectItem
                    {
                        Title = "BSIT 31E3 Prelim Assignment 2",

                        Stage = ProjectStage.Prelim,

                        RepoUrl = "https://github.com/Chant-prog/BSIT31E3_Prelim_A2_PantaleonChristopherAntonio.git",

                        Description = "Prelim Assignment 2 coursework project.",

                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC"
                        },

                        ImagePath = "~/images/projects/prelim-a2.png"
                    },

                    new ProjectItem
                    {
                        Title = "Happy Birthday Web App",

                        Stage = ProjectStage.PreFinal,

                        RepoUrl = "https://github.com/Chant-prog/happy-birthday-beb.git",

                        Description = "A personal birthday greeting web application.",

                        TechStack = new List<string>
                        {
                            "HTML",
                            "CSS",
                            "JavaScript"
                        },

                        ImagePath = "~/images/projects/happy-birthday.png"
                    }
                }
            };

            return View(profile);
        }
    }
}