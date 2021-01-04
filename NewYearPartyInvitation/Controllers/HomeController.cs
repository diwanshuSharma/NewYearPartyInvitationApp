using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewYearPartyInvitation.Controllers
{
    public class HomeController : Controller
    {
        // Action Method
        // GET: /Home/Index/      No parameters in this case
        public ActionResult Index()
        {
            // View() base class Method
            // Controller
            return View();
        }
    }
}