using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld_Junha_17_XIR1.Controllers
{
    public class helloController : Controller
    {
        // GET: hello
        public ActionResult Index()
        {
            return View();
        }
    }
}