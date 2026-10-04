using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
	// This is Arthryve Karunungan's portfolio merged into the FINAL EXAM structure.
	// The controller intentionally uses the final-exam project's existing models.
	[Classmate("Karunungan, Arthryve")]
	public class KarununganArthryveController : Controller
	{
		public IActionResult Index()
		{
			var profile = new ClassmateProfile
			{
				FullName = "Arthryve Karunungan",

				Tagline = "BS Information Technology Student | IT Elective 2",

				Course = "BS Information Technology",

				Section = "31E3",

				Bio = "Coursework portfolio for IT Elective 2, showcasing activities, projects, examinations, and system development work.",

				PhotoPath = "~/images/arthryve.jpg",

				Email = "arthryvekarunungan@gmail.com",

				GitHubUrl = "https://github.com/arthryvekarunungan",

				Skills = new List<string>
				{
					"C#",
					".NET",
					"ASP.NET Core",
					"MVC",
					"Razor",
					"HTML",
					"CSS",
					"JavaScript",
					"MySQL",
					"Git",
					"GitHub"
				},

				Projects = new List<ProjectItem>
				{
					new ProjectItem
					{
						Title = "Pre-Final Exam Project",

						Stage = ProjectStage.PreFinal,

						RepoUrl = "https://github.com/arthryvekarunungan/IT_ELECTIVE_2_-BSIT-31E3-_PREFINAL_EXAM_KARUNUNGAN_ARTHRYVE.git",

						Description = "Pre-final examination project for IT Elective 2.",

						TechStack = new List<string>
						{
							"C#",
							"ASP.NET Core MVC",
							"HTML",
							"CSS"
						},

						ImagePath = "~/images/projects/prefinal-exam.png"
					},

					new ProjectItem
					{
						Title = "Midterm Exam Project",

						Stage = ProjectStage.Midterm,

						RepoUrl = "https://github.com/arthryvekarunungan/-IT_ELECTIVE_2_MIDTERM_EXAM_10_Karunungan_Arthryve.git",

						Description = "Midterm examination project for IT Elective 2.",

						TechStack = new List<string>
						{
							"C#",
							"ASP.NET Core MVC",
							"HTML",
							"CSS"
						},

						ImagePath = "~/images/projects/midterm-exam.png"
					},

					new ProjectItem
					{
						Title = "Midterm Quiz 3",

						Stage = ProjectStage.Midterm,

						RepoUrl = "https://github.com/arthryvekarunungan/IT_ELECTIVE_2_MIDTERM_Q3_Karunungan_Arthryve.git",

						Description = "Midterm Quiz 3 project submission.",

						TechStack = new List<string>
						{
							"C#",
							"ASP.NET Core MVC"
						},

						ImagePath = "~/images/projects/midterm-q3.png"
					},

					new ProjectItem
					{
						Title = "Midterm Quiz 2",

						Stage = ProjectStage.Midterm,

						RepoUrl = "https://github.com/arthryvekarunungan/IT_ELECTIVE_2_MIDTERM_Q2_Karunungan_Arthryve.git",

						Description = "Midterm Quiz 2 project submission.",

						TechStack = new List<string>
						{
							"C#",
							"ASP.NET Core MVC"
						},

						ImagePath = "~/images/projects/midterm-q2.png"
					}
				}
			};

			return View(profile);
		}
	}
}