using System;
using Microsoft.AspNetCore.Mvc;

namespace Tasks.Controllers
{
	public class HomeController:Controller
	{
		public ViewResult Index()
		{
			ViewResult vr = new ViewResult();
			vr.ViewName = "index";

			return vr;
		}

        public ViewResult About()
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "about";

            return vr;
        }

        public ViewResult Contact()
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "contact";

            return vr;
        }

    }
}

