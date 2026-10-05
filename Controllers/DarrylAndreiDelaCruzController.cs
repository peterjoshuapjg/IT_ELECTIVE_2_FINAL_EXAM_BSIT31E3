using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Dela Cruz, Darryl Andrei M.")]
    public class DarrylAndreiDelaCruzController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Darryl Andrei M. Dela Cruz",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "IT Elective 2 coursework portfolio covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "~/images/darryl.jpg",
                Email = "ddarryl789@gmail.com",
                GitHubUrl = "https://github.com/ddarryl789-alt",

                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "HTML",
                    "CSS",
                    "GitHub",
                    "Git",
                    "Web Development"
                },

                Projects = new List<ProjectItem>
                {
                    // =========================
                    // PRELIM
                    // =========================

                    new ProjectItem
                    {
                        Title = "Prelim Quiz 1 - OOP Challenge",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/ddarryl789-alt/BSIT_31E1_PRELIM_Q1_Delacruz_Darryl-andrei",
                        Description = "An object-oriented programming challenge and reflection activity completed during the Prelim period.",
                        TechStack = new List<string> { "C#", ".NET", "OOP" },
                        ImagePath = "~/images/projects/project1.png"
                    },

                    new ProjectItem
                    {
                        Title = "Prelim H1 - Assignment One",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_2_Assignment_One",
                        Description = "A C# console application with a menu-driven system for student grades, averages, class average, and highest grade.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/project2.png"
                    },

                    new ProjectItem
                    {
                        Title = "Prelim H2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/ddarryl789-alt/BSIT31E3_PRELIM_H2_DELACRUZ_DARRYL-ANDREI",
                        Description = "An IT Elective 2 Prelim activity completed as part of the required coursework.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/project3.png"
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_2_PRELIM_EXAM_DelaCruz_Darrylandrei",
                        Description = "The IT Elective 2 Prelim examination project submitted for the course requirements.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core" },
                        ImagePath = "~/images/projects/project4.png"
                    },

                    // =========================
                    // MIDTERM
                    // =========================

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Hackathon - Personality Test",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/ddarryl789-alt/Hackthon---Personality-test",
                        Description = "A personality test web application created as part of the IT Elective 2 Hackathon.",
                        TechStack = new List<string> { "HTML", "CSS" },
                        ImagePath = "~/images/projects/project5.png"
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Project - Model Binding Demo",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/ddarryl789-alt/ModelBindingDemo",
                        Description = "An ASP.NET Core MVC project demonstrating model binding and handling form data.",
                        TechStack = new List<string> { "C#", "ASP.NET Core", "MVC" },
                        ImagePath = "~/images/projects/project6.png"
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_2_TEMPLATE",
                        Description = "An IT Elective 2 midterm quiz activity based on the provided MVC template.",
                        TechStack = new List<string> { "C#", "ASP.NET Core", "MVC" },
                        ImagePath = "~/images/projects/project7.png"
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Q3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_2_Dela-Cruz_Darryl-andrei_MID",
                        Description = "An IT Elective 2 Midterm Question 3 project completed as part of the course requirements.",
                        TechStack = new List<string> { "C#", "ASP.NET Core", "MVC" },
                        ImagePath = "~/images/projects/project8.png"
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Exam - Job Posting Board",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_2_MIDTERM_EXAM_JobpostingBoard_Darryl-Dela-Cruz_Set10",
                        Description = "An ASP.NET Core MVC job posting board application for creating and viewing job postings.",
                        TechStack = new List<string> { "C#", "ASP.NET Core", "MVC", "HTML", "CSS" },
                        ImagePath = "~/images/projects/project9.png"
                    },

                    // =========================
                    // PREFINAL
                    // =========================

                    new ProjectItem
                    {
                        Title = "Prefinals Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_2_BSIT33E3_PREFINAL_EXAM_DelaCruz_Darryl",
                        Description = "An ASP.NET Core MVC application containing questions and answers for the IT Elective 2 Prefinals examination.",
                        TechStack = new List<string> { "C#", "ASP.NET Core", "MVC" },
                        ImagePath = "~/images/projects/project10.png"
                    },

                    new ProjectItem
                    {
                        Title = "Prefinals Team Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_PREFINALS_PROJECT",
                        Description = "A team-based IT Elective 2 project completed during the Prefinals period.",
                        TechStack = new List<string> { "C#", "ASP.NET Core", "MVC", "GitHub" },
                        ImagePath = "~/images/projects/project11.png"
                    }
                }
            };

            return View(profile);
        }
    }
}