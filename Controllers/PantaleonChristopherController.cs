using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
	public class PantaleonChristopherController : Controller
	{
		public IActionResult Index()
		{
			var profile = new ClassmateProfile
			{
				FullName = "Christopher Antonio D. Pantaleon",
				Tagline = "BS Information Technology Student | IT Elective 2",
				Course = "BS Information Technology",
				Section = "31E3",

				Bio = "A BS Information Technology student showcasing projects, activities, and skills in web development, system development, and information technology.",

				PhotoPath = "~/images/christopher.jpg",

				Email = "christopherpantaleon@gmail.com",

				GitHubUrl = "https://github.com/ChristopherPantaleon",

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
					"VB.NET",
					"MySQL",
					"Git",
					"GitHub"
				},

				Projects = new List<ProjectItem>
				{
					new ProjectItem
					{
						Title = "IT Management System",
						Stage = ProjectStage.Midterm,
						RepoUrl = "https://github.com/ChristopherPantaleon/IT_ELECTIVE_2_MIDTERM_EXAM",
						Description = "A web-based IT management system designed to manage IT operations, users, services, and other IT-related activities.",

						TechStack = new List<string>
						{
							"C#",
							"ASP.NET Core MVC",
							"HTML",
							"CSS"
						},

						ImagePath = "~/images/projects/it-management.png"
					},

					new ProjectItem
					{
						Title = "Student Management System",
						Stage = ProjectStage.Midterm,
						RepoUrl = "https://github.com/ChristopherPantaleon/IT_ELECTIVE_2_MIDTERM_EXAM",
						Description = "A system designed to organize and manage student information and academic records through a simple web interface.",

						TechStack = new List<string>
						{
							"C#",
							"ASP.NET Core MVC",
							"SQL"
						},

						ImagePath = "~/images/projects/student-management.png"
					},

					new ProjectItem
					{
						Title = "Vehicle Service Monitoring",
						Stage = ProjectStage.Midterm,
						RepoUrl = "https://github.com/ChristopherPantaleon/IT_ELECTIVE_2_MIDTERM_EXAM",
						Description = "A vehicle service monitoring system that allows users to track service jobs, customer information, vehicle details, service status, and release information.",

						TechStack = new List<string>
						{
							"C#",
							"ASP.NET Core MVC",
							"BCrypt",
							"HTML",
							"CSS"
						},

						ImagePath = "~/images/projects/vehicle-service.png"
					},

					new ProjectItem
					{
						Title = "Eyelottea Restobar POS",
						Stage = ProjectStage.Prelim,
						RepoUrl = "https://github.com/ChristopherPantaleon/IT_ELECTIVE_2_MIDTERM_EXAM",
						Description = "A VB.NET Windows Forms application created to manage transactions, orders, payments, and inventory for a restobar.",

						TechStack = new List<string>
						{
							"VB.NET",
							"Windows Forms",
							"MySQL"
						},

						ImagePath = "~/images/projects/eyelottea.png"
					}
				}
			};

			return View(profile);
		}
	}
}

