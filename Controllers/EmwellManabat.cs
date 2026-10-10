using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // This is Emwell Manabat's portfolio merged into the FINAL EXAM structure.
    [Classmate("Manabat, Emwell")]
    public class EmwellManabatController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Emwell Manabat",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Midterm and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "~/images/emwell.jpg",
                Email = "emwellmanabat@gmail.com",
                GitHubUrl = "https://github.com/Well0106",
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
                        Title = "Faculty Evaluation System",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Well0106/-IT_ELECTIVE_2_MIDTERM_EXAM_-Faculty-Evaluation-System-_-Emwell-",
                        Description = "Midterm practical exam: A web-based Faculty Evaluation System built with C# and .NET.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core" },
                        ImagePath = "~/images/projects/midterm-exam-faculty-evaluation.png"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Well0106/IT_ELECTIVE_2_MIDTERM_Q2_Manabat_Emwell",
                        Description = "Second quiz of the Midterm term for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/midterm-quiz-2.png"
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Well0106/IT_ELECTIVE_2_MIDTERM_Q3_Manabat_Emwell",
                        Description = "Third quiz of the Midterm term for IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/midterm-quiz-3.png"
                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/Well0106/IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Manabat_Emwell",
                        Description = "Practical exam for the Prefinals term of IT Elective 2.",
                        TechStack = new List<string> { "C#", ".NET" },
                        ImagePath = "~/images/projects/prefinals-exam.png"
                    }
                }
            };

            return View(profile);
        }
    }
}