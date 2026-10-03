using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // This is Patricia Reosa's portfolio merged into the FINAL EXAM structure.
    // The controller intentionally uses the final-exam project's existing models.
    [Classmate("Reosa, Patricia ")]
    public class PatriciaReosaController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Patricia Reosa",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = "\"C:\\Users\\user\\Downloads\\pate.jpg\"",
                Email = "patriciareosa@gmail.com",
                GitHubUrl = "https://github.com/patriciareosa",
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
    Title = "Prelim A1",
    Stage = ProjectStage.Prelim,
    RepoUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_A1_REOSA_PATRICIA",
    Description = "A project created for the IT Elective 2 Prelim A1 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project1.png"
},

new ProjectItem
{
    Title = "Prelim A2",
    Stage = ProjectStage.Prelim,
    RepoUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_A2_REOSA_PATRICIA",
    Description = "A project created for the IT Elective 2 Prelim A2 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project2.png"
},

new ProjectItem
{
    Title = "Prelim A3",
    Stage = ProjectStage.Prelim,
    RepoUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_A3_REOSA_PATRICIA",
    Description = "A project created for the IT Elective 2 Prelim A3 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project3.png"
},

new ProjectItem
{
    Title = "Prelim Q1",
    Stage = ProjectStage.Prelim,
    RepoUrl = "https://github.com/patriciareosa/BSIT_31E3_PRELIM_Q1_REOSA_PATRICIA",
    Description = "A project created for the IT Elective 2 Prelim Q1 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project4.png"
},

new ProjectItem
{
    Title = "Prelim H1",
    Stage = ProjectStage.Prelim,
    RepoUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_H1_REOSA_PATRICIA",
    Description = "A project created for the IT Elective 2 Prelim H1 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project5.png"
},

new ProjectItem
{
    Title = "Prelim H2",
    Stage = ProjectStage.Prelim,
    RepoUrl = "https://github.com/patriciareosa/BSIT31E3_PRELIM_H2_REOSA_PATRICIA",
    Description = "A project created for the IT Elective 2 Prelim H2 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project6.png"
},

new ProjectItem
{
    Title = "Prelim Exam",
    Stage = ProjectStage.Prelim,
    RepoUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_PRELIM_EXAM_REOSA_PATRICIA",
    Description = "The Prelim Examination project for IT Elective 2.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project7.png"
},

new ProjectItem
{
    Title = "Midterm A1",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_Midterm_A1_Reosa_Patricia",
    Description = "A project created for the IT Elective 2 Midterm A1 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project8.png"
},

new ProjectItem
{
    Title = "Midterm Q1",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_MIDTERM_Q1",
    Description = "A project created for the IT Elective 2 Midterm Q1 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project9.png"
},

new ProjectItem
{
    Title = "Midterm Q2",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_MIDTERM_Q2_Reosa_Patricia",
    Description = "A project created for the IT Elective 2 Midterm Q2 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project10.png"
},

new ProjectItem
{
    Title = "Midterm Q3",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_MIDTERM_Q3_Reosa_Patricia",
    Description = "A project created for the IT Elective 2 Midterm Q3 activity.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project11.png"
},

new ProjectItem
{
    Title = "Poketext",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/daimeryayap26-ship-it/Poketext",
    Description = "A project created as part of the IT Elective 2 activities.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project12.png"
},

new ProjectItem
{
    Title = "Midterm Exam Set 8",
    Stage = ProjectStage.Midterm,
    RepoUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_MIDTERM_EXAM_Set8_Reosa_Patrici",
    Description = "The Midterm Examination Set 8 project for IT Elective 2.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project13.png"
},

new ProjectItem
{
    Title = "IT Elective 2 - Prefinal Exam",
    Stage = ProjectStage.PreFinal,
    RepoUrl = "https://github.com/patriciareosa/IT_ELECTIVE_2_BSIT-31E3_PREFINAL_EXAM_Reosa_Patricia",
    Description = "The Pre-Final Examination project for IT Elective 2.",
    TechStack = new List<string> { "C#" },
    ImagePath = "~/images/projects/project14.png"
},

new ProjectItem
{
    Title = "IT Elective 2 - H1 Student Shipped Work",
    Stage = ProjectStage.PreFinal,
    RepoUrl = "https://itmlyceumalabang-my.sharepoint.com/:x:/g/personal/c1816-24_itmlyceumalabang_onmicrosoft_com/IQA3xmnXedf2SZqG1r3rBEn4AZjORvooH7AujrcUjAFGLAI?e=acdV3p",
    Description = "Student Shipped Work submitted as part of the IT Elective 2 Pre-Finals activities.",
    TechStack = new List<string> { "Microsoft Excel" },
    ImagePath = "~/images/projects/project15.png"
},

new ProjectItem
{
    Title = "IT Elective - Pre-Finals Project",
    Stage = ProjectStage.PreFinal,
    RepoUrl = "https://github.com/BorromeoRonalyn/IT_ELECTIVE_PRE-FINALS_PROJECT",
    Description = "A project created for the IT Elective Pre-Finals.",
    TechStack = new List<string> { "C#", "ASP.NET Core MVC" },
    ImagePath = "~/images/projects/project16.png"
}
                }
            };

            return View(profile);
        }
    }
}
