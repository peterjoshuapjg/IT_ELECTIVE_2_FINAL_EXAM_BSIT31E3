using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    [Classmate("Quimson, Allen Dwayn T.")]
    public class AllenQuimsonController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Allen Dwayn T. Quimson",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "~/images/allen.jpg",
                Email = "allendwaynquimson@gmail.com",
                GitHubUrl = "https://github.com/Allen3115",
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
                        Title = "Project 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Allen3115/BSIT31E3_PRELIM_A1_QUIMSON_ALLEN",
                        Description = "First activity, familiarization with git and github.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Project 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Allen3115/BSIT31E3_PRELIM_A2_Quimson_Allen",
                        Description = "Second activity, simple conditional statement practices.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Project 3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Allen3115/BSIT31E3_PRELIM_H1_QUIMSON_ALLEN",
                        Description = "Student adding and grading system.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Project 4",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Allen3115/IT_ELECTIVE_2_PRELIM_EXAM_Quimson_Allen",
                        Description = "Prelim examination,",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Project 5",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Allen3115/Prelims-Loan-Calculator-Program_Quimson",
                        Description = "Prelim activity, loan calculator program.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "Project 6",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Allen3115/IT_ELECTIVE_2_TEMPLATE",
                        Description = "Music playlist web app.",
                        TechStack = new List<string> { "C#", ".NET", "HTML", "CSS", "JavaScript" }
                    },
                    new ProjectItem
                    {
                        Title = "Project 7",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/Allen3115/IT_ELECTIVE_2_BSIT31-E3_PREFINAL_EXAM_Quimson_Allen",
                        Description = "Prefinal Examination, question and answers.",
                        TechStack = new List<string> { "C#", ".NET", "HTML", "CSS", "JavaScript" }
                    }
                }
            };
            return View(profile);
        }
    }
}