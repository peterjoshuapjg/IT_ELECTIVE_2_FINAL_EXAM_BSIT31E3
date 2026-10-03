using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // This is Danielle Allyne Marcos's portfolio merged into the FINAL EXAM structure.
    // The controller intentionally uses the final-exam project's existing models.
    [Classmate("Marcos, Danielle Allyne ")]
    public class MarcosController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Danielle Allyne Marcos",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "\"C:\\Users\\danie\\Downloads\\Image.jpg\".jpg",
                Email = "daniellemarcos3@gmail.com",
                GitHubUrl = "https://github.com/daniellemarcos3",
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
    Title = "Prelim Quiz 1",
    Stage = ProjectStage.Prelim,
    RepoUrl = "https://github.com/daniellemarcos3/BSIT_31E3_PRELIM_Q1_MARCOS_DANIELLE-ALLYNE",
    Description = "A web-based project created for the IT Elective 2 preliminary activity.",
    TechStack = new List<string> { "C#", ".NET" },
    ImagePath = "~/images/projects/prelim-quiz1.png"
},

new ProjectItem
{
    Title = "Midterm Activity 1",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/daniellemarcos3/IT_ELECTIVE_2_Midterm_A1_Marcos_Danielle-Allyne",
    Description = "An ASP.NET Core MVC project created as part of the IT Elective 2 midterm activities.",
    TechStack = new List<string> { "C#", ".NET" },
    ImagePath = "~/images/projects/midterm-activity1.png"
},

new ProjectItem
{
    Title = "Midterm Quiz 2",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/daniellemarcos3/IT_ELECTIVE_2_MIDTERM_Q2_Marcos_DanielleAllyne",
    Description = "A web application project developed for the second midterm quiz.",
    TechStack = new List<string> { "C#", ".NET" },
    ImagePath = "~/images/projects/midterm-quiz2.png"
},

new ProjectItem
{
    Title = "Midterm Quiz 3",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/daniellemarcos3/IT_ELECTIVE_2_MIDTERM_Q3",
    Description = "An ASP.NET Core MVC application created for the third midterm quiz.",
    TechStack = new List<string> { "C#", ".NET" },
    ImagePath = "~/images/projects/midterm-q3.png"
},

new ProjectItem
{
    Title = "Portfolio",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/daniellemarcos3/Portfolio",
    Description = "A personal portfolio website created using ASP.NET Core MVC to showcase projects and skills.",
    TechStack = new List<string> { "C#", ".NET" },
    ImagePath = "~/images/projects/Portfolio.png"
},

new ProjectItem
{
    Title = "Point of Sales",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/daniellemarcos3/Point-of-Sales",
    Description = "A simple point-of-sale web application for managing products and shopping cart transactions.",
    TechStack = new List<string> { "C#", ".NET" },
    ImagePath = "~/images/projects/point-of-sales.png"
},

                }
            };

            return View(profile);
        }
    }
}
