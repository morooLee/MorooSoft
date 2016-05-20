using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MorooSoft.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult HostManager()
        {
            return View();
        }
    }
}