using System;
using Microsoft.AspNetCore.Mvc;

namespace Tasks.Controllers
{
	public class StudentController:Controller
	{

		public ViewResult Detail(int id, string name="Seymur",string surname="Fahradov")
		{
			ViewBag.id = id;
			ViewBag.name = name;
			ViewBag.surname = surname;
			return View();
		}

	}
}

