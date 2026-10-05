using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{

    [Classmate("Bernaldez, Bernadette ")]
    public class BernadetteBernaldezController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Bernadette Bernaldez",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = " ",
                Email = "bernadettebernaldez02@gmail.com",
                GitHubUrl = "https://github.com/bernadettebbb",
                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "GitHub",
                    "Git",

                },
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                   {
                        Title = "Prelim Quiz 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/bernadettebbb/BSIT_31E3_PRELIM_Q1_Bernaldez_Bernadette.git",
                        Description = "Prelim Quiz 1 project.",
                        TechStack = new List<string> { "C#", ".NET" },

                    },
                    new ProjectItem
                    {
                        Title = "Prelim Activity 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/bernadettebbb/BSIT31E3_PRELIM_A1_BERNALDEZ_BERNADETTE.git",
                        Description = "Prelim activity focused on the fundamentals covered in class.",
                        TechStack = new List<string> { "C#", ".NET" },

                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-On 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/bernadettebbb/BSIT31E3_PRELIM_H1_BERNALDEZ_BERNADETTE.git",
                        Description = "Prelim hands-on 1.",
                        TechStack = new List<string> { "C#", ".NET" },

                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-On 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/bernadettebbb/BSIT31E3_PRELIM_H2_BERNALDEZ_BERNADETTE.git",
                        Description = "Prelim Hands-On 2.",
                        TechStack = new List<string> { "C#", ".NET" },

                    },
                    new ProjectItem
                    {
                        Title = "Prelim Q1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/bernadettebbb/BSIT31E3_PRELIM_Q1_BERNALDEZ_BERNADETTE.git",
                        Description = "Prelim Quiz 1.",
                        TechStack = new List<string> { "C#", ".NET" },

                    },
                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/bernadettebbb/IT_ELECTIVE_2_PRELIM_EXAM_BERNALDEZ_BERNADETTE.git",
                        Description = "Prelim examination.",
                        TechStack = new List<string> { "C#", ".NET" },

                    },
                    new ProjectItem
                    {
                        Title = "Midterm Q2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/bernadettebbb/IT_ELECTIVE_2_MIDTERM_Q2_Bernaldez_Bernadette.git",
                        Description = "Midterm Quiz 2.",
                        TechStack = new List<string> { "C#", ".NET" },

                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Quiz",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/bernadettebbb/IT_ELECTIVE_2_PREFINALS_QUIZ_BERNALDEZ_BERNADETTE.git",
                        Description = "Prefinals Quiz.",
                        TechStack = new List<string> { "C#", ".NET" },

                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/bernadettebbb/IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Bernaldez_Bernadette.git",
                        Description = "Prefinals Exam.",
                        TechStack = new List<string> { "C#", ".NET" },
                    
                    }

                }
            };

            return View(profile);
        }
    }
}
