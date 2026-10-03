using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // This is Sophia Sumalinog's portfolio merged into the FINAL EXAM structure.
    // The controller intentionally uses the final-exam project's existing models.
    [Classmate("Sumalinog, Sophia")]
    public class SophiaSumalinogController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Sophia Sumalinog",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "~/images/ace.jpg",
                Email = "c1982-24@itmlyceumalabang.onmicrosoft.com",
                GitHubUrl = "https://github.com/AceySumalinog",

                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "GitHub",
                    "Git",
                    "Web Development"
                },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "FizzBuzz Program",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/AceySumalinog/BSIT31E3_PRELIM_A1_SUMALINOG_SOPHIA",
                        Description = "A C# console application implementing the classic FizzBuzz programming problem.",
                        TechStack = new List<string> { "C#" },
                        ImagePath = "~/images/project1.png"
                    },

                    new ProjectItem
                    {
                        Title = "Calculator Application",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/AceySumalinog/BSIT31E3_PRELIM_A2_SUMALINOG_SOPHIA",
                        Description = "A C# calculator application with loops, user input handling, and validation.",
                        TechStack = new List<string> { "C#" },
                        ImagePath = "~/images/project2.png"
                    },

                    new ProjectItem
                    {
                        Title = "Student Management System",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/AceySumalinog/BSIT31E3_PRELIM_H1_SUMALINOG_SOPHIA",
                        Description = "A procedural C# student management system designed to manage student information.",
                        TechStack = new List<string> { "C#" },
                        ImagePath = "~/images/project3.png"
                    },

                    new ProjectItem
                    {
                        Title = "Transport Resolver",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/AceySumalinog/BSIT_31E3_PRELIM_Q1_SUMALINOG_SOPHIA",
                        Description = "An object-oriented C# application demonstrating interfaces and different types of transportation.",
                        TechStack = new List<string> { "C#", "OOP" },
                        ImagePath = "~/images/project4.png"
                    },

                    new ProjectItem
                    {
                        Title = "OOP & REST API Project",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_PRELIM_EXAM_SUMALINOG_SOPHIA",
                        Description = "A C# project demonstrating object-oriented programming principles and HTTP Client REST API consumption.",
                        TechStack = new List<string> { "C#", ".NET", "REST API" },
                        ImagePath = "~/images/project5.png"
                    },

                    new ProjectItem
                    {
                        Title = "Playlist Application",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_MIDTERM_Q2_Sumalinog_Sophia",
                        Description = "An ASP.NET Core MVC playlist application with authentication and session-based access.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "Bootstrap" },
                        ImagePath = "~/images/project6.png"
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Assignment 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_Midterm_A1_Sumalinog_Sophia",
                        Description = "A C# programming assignment completed as part of the IT Elective 2 coursework.",
                        TechStack = new List<string> { "C#" },
                        ImagePath = "~/images/project7.png"
                    },

                    new ProjectItem
                    {
                        Title = "Chapter One POS System",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Sumalinog_Sophia",
                        Description = "A Point of Sale web application for a specialty Manga and Manhwa bookstore.",
                        TechStack = new List<string> { "ASP.NET Core", "C#", "HTML", "CSS", "JavaScript" },
                        ImagePath = "~/images/project8.png"
                    },

                    new ProjectItem
                    {
                        Title = "MVC.Auth Portfolio Guard",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_MIDTERM_Q3_Sumalinog_Sophia",
                        Description = "An ASP.NET MVC authentication project featuring login, logout, forgot password, and change password functionality.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "HTML", "CSS" },
                        ImagePath = "~/images/project9.png"
                    },

                    new ProjectItem
                    {
                        Title = "Vehicle Service Monitoring System",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/AceySumalinog/IT_ELECTIVE_2_MIDTERM_EXAM_1_Sumalinog_Sophia",
                        Description = "A system designed to monitor vehicle service and maintenance information.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/project10.png"
                    },

                    new ProjectItem
                    {
                        Title = "Manhwa Level-Up MVC System",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/AceySumalinog/-IT_ELECTIVE_2_-BSIT-31E3-_PREFINAL_EXAM_Sumalinog_Sophia",
                        Description = "A creative ASP.NET Core MVC exam application inspired by a manhwa level-up system.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "HTML", "CSS", "JavaScript" },
                        ImagePath = "~/images/proj11.png"
                    }
                }
            };

            return View(profile);
        }
    }
}