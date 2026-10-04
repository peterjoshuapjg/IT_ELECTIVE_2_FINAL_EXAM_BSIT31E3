using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
   
    [Classmate("Rivel, John Cristian ")]
    public class JohnCristianRivelController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "John Cristian Rivel",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "31E3",
                Bio = "Coursework portfolio for IT Elective 2, covering Prelims, Midterm, and Prefinals activities, quizzes, exams, and projects.",
                PhotoPath = " ",
                Email = "johnrivel52@gmail.com",
                GitHubUrl = "https://github.com/JohnRivell",
                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "GitHub",
                    "Git",
                    "Web Development",
                    "Game Development",
                    "3D Modeling",

                },
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                   {
                        Title = "Prelim Quiz 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/JohnRivel/BSIT_31E3_PRELIM_Q1_Rivel_JohnCristian.git",
                        Description = "Prelim Quiz 1 project.",
                        TechStack = new List<string> { "C#", ".NET" },
                        
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Activity 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/JohnRivel/BSIT31A3_Prelim_A1_RivelJohnCristian.git",
                        Description = "Prelim activity focused on the fundamentals covered in class.",
                        TechStack = new List<string> { "C#", ".NET" },
                    
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-On 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/JohnRivel/BSIT31E3_PRELIM_H1_Rivel_JohnCristian.git",
                        Description = "Prelim hands-on activity demonstrating the first set of practical skills.",
                        TechStack = new List<string> { "C#", ".NET" },
            
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-On 1 (Alternate)",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/JohnRivel/BSIT31E3_PRELIM_H1_Rivel_JohnCristianI..git",
                        Description = "Second repository for Prelim Hands-On 1.",
                        TechStack = new List<string> { "C#", ".NET" },
                      
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Hands-On 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/JohnRivel/BSIT31E3_PRELIM_H2_Rivel_JohnCristian.git",
                        Description = "Prelim Hands-On 2 project.",
                        TechStack = new List<string> { "C#", ".NET" },
                     
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/JohnRivel/IT_ELECTIVE_2_PRELIM_EXAM_Rivel_JohnCristian.git",
                        Description = "Prelim examination project.",
                        TechStack = new List<string> { "C#", ".NET" },
         
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Hands-On 1 to 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/JohnRivel/RIVEL_IT_ELECTIVE_2_MIDTERM_H1_H2_H3.git",
                        Description = "Collection of the Midterm Hands-On 1, 2 and 3 activities.",
                        TechStack = new List<string> { "C#", ".NET" },
                   
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 2 Backup",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/JohnRivel/IT_ELECTIVE_2_MIDTERM_Q2_Rivel_JohnCristian_Backup.git",
                        Description = "Backup repository for the Midterm Quiz 2 project.",
                        TechStack = new List<string> { "C#", ".NET" },
                 
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/JohnRivel/Rivel_IT_ELECTIVE_2_MIDTERM_Q3.git",
                        Description = "Midterm Quiz 3 project.",
                        TechStack = new List<string> { "C#", ".NET" },
               
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/JohnRivel/RIVEL_IT_ELECTIVE_2_MIDTERM_EXAM.git",
                        Description = "Midterm examination project.",
                        TechStack = new List<string> { "C#", ".NET" },
                      
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam Set 5",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/JohnRivel/IT_ELECTIVE_2_MIDTERM_EXAM_SET_5_RIVEL_JOHNCRISTIAN.git",
                        Description = "Midterm examination project for Set 5.",
                        TechStack = new List<string> { "C#", ".NET" },
               
                    },
                    new ProjectItem
                    {
                        Title = "Prefinal Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/JohnRivel/ITELECTIVE2_PREFINAL_RIVEL.git",
                        Description = "Prefinal project bringing together the major concepts from the course.",
                        TechStack = new List<string> { "C#", ".NET", "GitHub" },
               
                    },
                    new ProjectItem
                    {
                        Title = "Prefinals Quiz (Portfolio)",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/JohnRivel/RIVEL_BSIT31E3_PREFINALS_QUIZ.git",
                        Description = "ASP.NET Core MVC portfolio of my IT Elective 2 projects, with a login, project detail pages and comments.",
                        TechStack = new List<string> { "C#", ".NET", "ASP.NET Core" },
               
                    },
                    new ProjectItem
                    {
                        Title = "Prefinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/JohnRivel/IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_RIVEL_JOHNCRISTIAN.git",
                        Description = "Prefinal examination project.",
                        TechStack = new List<string> { "C#", ".NET" },
               
                    }

                }
            };

            return View(profile);
        }
    }
}
