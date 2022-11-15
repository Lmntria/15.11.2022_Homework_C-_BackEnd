using System;
using Microsoft.AspNetCore.Mvc;

namespace _15._11._2022_Homework.Controllers
{
	public class HomeController:Controller
	{
		public ViewResult Index()
		{
			ViewResult vr = new ViewResult();
			vr.ViewName = "Index";

			return vr;
		}



		public ViewResult About()
		{
			ViewResult vr = new ViewResult();
			vr.ViewName = "about";

			return vr;
		}


		public ContentResult Content(int id,string name,string surname)
		{
			ContentResult cr = new ContentResult();
			cr.Content = $"Fullname:{id} - {name} {surname}";

			return cr;
		}

		public ViewResult Contact()
		{

			return View();
		}


		public ViewResult Detail(int id,string name,string surname)
		{
			ViewBag.id = id;
			ViewBag.name = name;

			return View();
		}
	}
}

