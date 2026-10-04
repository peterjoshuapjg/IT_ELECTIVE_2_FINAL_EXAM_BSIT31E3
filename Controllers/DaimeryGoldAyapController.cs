using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Ayap, Daimery Gold")]
    public class DaimeryGoldAyapController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Daimery Gold Ayap",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "~/images/daimerygold.jpg",
                Email = "daimerygold@gmail.com",
                GitHubUrl = "https://github.com/daimerygold",

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
                        Title = "BSIT31E1 Prelim H1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/daimeryayap26-ship-it/BSIT31E1_PRELIM_H1_AYAP_DAIMERY",
                        Description = "Prelim hands-on activity for BSIT 31E1 focusing on core Web Development.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "Web Development"
                        },
                        ImagePath = "~/images/project1.jpg"
                    },

                    new ProjectItem
                    {
                        Title = "Weather Forecast App",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/daimeryayap26-ship-it/Weather_Forecast_Ayap",
                        Description = "A sleek weather forecast application that tracks live climate data.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "ASP.NET Core"
                        },
                        ImagePath = "~/images/project2.jpg"
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective BSIT 31E3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_BSIT_31E3_ayap_daimerygold",
                        Description = "Coursework and project repository for IT Elective BSIT 31E3.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "GitHub"
                        },
                        ImagePath = "~/images/project3.jpg"
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm H1-H3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_2_MIDTERM_H1_H2_H3",
                        Description = "Midterm hands-on activities 1 to 3 for IT Elective 2.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        },
                        ImagePath = "~/images/project4.jpg"
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_2_MIDTERM_EXAM_9_DaimeryAyap",
                        Description = "Midterm examination project implementation for IT Elective 2.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        },
                        ImagePath = "~/images/project5.jpg"
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Q3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_2_MIDTERM_Q3",
                        Description = "Midterm quiz 3 hands-on repository.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        },
                        ImagePath = "~/images/project6.jpg"
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Assignment One",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/daimeryay26-ship-it/Ayap_IT_ELECTIVE_2_Assignment_One",
                        Description = "First assignment submission for IT Elective 2.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET"
                        },
                        ImagePath = "~/images/project7.jpg"
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Prefinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_2_BSIT-31E3_PREFINAL_EXAM_Ayap_DaimeryGold",
                        Description = "Prefinal examination project repository for BSIT 31E3.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "GitHub"
                        },
                        ImagePath = "~/images/project8.jpg"
                    }
                }
            };

            return View(profile);
        }
    }
}