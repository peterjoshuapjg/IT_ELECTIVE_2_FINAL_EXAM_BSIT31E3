using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    public class DarrylAndreiDelaCruzController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Darryl Andrei M. Dela Cruz",
                Tagline = "BS Information Technology Student | IT Elective 2",
                Course = "BS Information Technology",
                Section = "33E3",
                Bio = "Coursework portfolio for IT Elective 2, featuring web development projects and activities.",
                PhotoPath = "~/images/darryl.jpg",
                Email = "",
                GitHubUrl = "https://github.com/ddarryl789-alt",

                Skills = new List<string>
                {
                    "C#",
                    ".NET",
                    "ASP.NET Core",
                    "HTML",
                    "CSS",
                    "GitHub",
                    "Web Development"
                },

                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Personality Test",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/ddarryl789-alt/Hackthon---Personality-test",
                        Description = "A personality test web application created as part of a hackathon project.",
                        TechStack = new List<string>
                        {
                            "HTML",
                            "CSS"
                        },
                        ImagePath = "~/images/projects/project1.png"
                    },

                    new ProjectItem
                    {
                        Title = "Job Posting Board",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_2_MIDTERM_EXAM_JobpostingBoard_Darryl-Dela-Cruz_Set10",
                        Description = "A web application for creating and viewing job posting information.",
                        TechStack = new List<string>
                        {
                            "HTML",
                            "CSS"
                        },
                        ImagePath = "~/images/projects/project2.png"
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective Assignment",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_2_Assignment_One",
                        Description = "A web project created for the IT Elective course.",
                        TechStack = new List<string>
                        {
                            "HTML",
                            "CSS"
                        },
                        ImagePath = "~/images/projects/project3.png"
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective Prefinals Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/ddarryl789-alt/IT_ELECTIVE_PREFINALS_PROJECT",
                        Description = "A project created for the IT Elective Prefinals requirements.",
                        TechStack = new List<string>
                        {
                            "C#",
                            ".NET",
                            "ASP.NET Core",
                            "GitHub"
                        },
                        ImagePath = "~/images/projects/project4.png"
                    }
                }
            };

            return View(profile);
        }
    }
}