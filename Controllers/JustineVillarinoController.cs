using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Villarino, Justine Nicole")]
    public class JustineVillarinoController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Justine Nicole Villarino",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",

                Bio = "A collection of my IT Elective 2 projects from Prelim, Midterm, and Prefinal.",

                PhotoPath =  "~/images/jastin.jpg",

                Email = "Thinevillarino@gmail.com",

                GitHubUrl = "https://github.com/thinevillarino",

                Skills = new List<string>
                {
                    "C#",
                    "ASP.NET Core",
                    "HTML",
                    "CSS",
                    "Git",
                    "GitHub"
                },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Quiz 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/thinevillarino/-BSIT_31E1_PRELIM_Q1_Villarino_Justine",
                        Description = "Prelim Quiz 1 project for IT Elective 2.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/thinevillarino/BSIT31E3_PRELIM_A2_VILLARINO-JUSTINE-NICOLE",
                        Description = "Prelim Activity 2 project for IT Elective 2.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/thinevillarino/IT_ELECTIVE_2_PRELIM_EXAM_-VILLARINO-_-JUSTINE-NICOLE-",
                        Description = "Prelim examination project for IT Elective 2.",
                        TechStack = new List<string> { "C#" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Activity 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/thinevillarino/IT_ELECTIVE_2_Midterm_A1_Villarino_Justine",
                        Description = "Midterm Activity 1 project for IT Elective 2.",
                        TechStack = new List<string> { "HTML" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm H1 H2 H3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/thinevillarino/IT_ELECTIVE_2_MIDTERM_H1_H2_H3",
                        Description = "Collection of Midterm activities for IT Elective 2.",
                        TechStack = new List<string> { "HTML" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/thinevillarino/IT_ELECTIVE_2_MIDTERM_Q3_Villarino",
                        Description = "Midterm Quiz 3 project for IT Elective 2.",
                        TechStack = new List<string> { "HTML" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/thinevillarino/IT_ELECTIVE_2_MIDTERM_EXAM_1_Villarino_Justine-Nicole",
                        Description = "Midterm examination project for IT Elective 2.",
                        TechStack = new List<string> { "HTML" }
                    },

                    new ProjectItem
                    {
                        Title = "Playlist App",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/thinevillarino/Playlist-App",
                        Description = "A playlist application created during IT Elective 2.",
                        TechStack = new List<string> { "HTML" }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinal Quiz",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/thinevillarino/IT_ELECTIVE_2_PREFINAL_QUIZ_Villarino_Justine",
                        Description = "Prefinal Quiz project for IT Elective 2.",
                        TechStack = new List<string> { "HTML" }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinals Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/thinevillarino/IT_ELECTIVE_PREFINALS_PROJECT",
                        Description = "Prefinals project created using ASP.NET Core.",
                        TechStack = new List<string> { "C#", "ASP.NET Core" }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/thinevillarino/IT_ELECTIVE_2_-BSIT31E3-_PREFINAL_EXAM_Villarino_Justine-Nicole",
                        Description = "Prefinal examination project for IT Elective 2.",
                        TechStack = new List<string> { "CSS", "ASP.NET Core" }
                    }
                }
            };

            return View(profile);
        }
    }
}