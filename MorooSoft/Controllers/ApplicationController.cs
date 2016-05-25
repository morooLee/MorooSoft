using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MorooSoft.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        //public ActionResult HostManager()
        //{
        //    return View();
        //}

        public ActionResult HostManager(String version)
        {
            //FileVersionInfo myFI = FileVersionInfo.GetVersionInfo("~/Files/HostManager/64Bit/HostManager.exe");
            FileVersionInfo myFI = FileVersionInfo.GetVersionInfo(@"C:\Users\moroo\OneDrive\문서\Visual Studio 2015\Projects\MorooSoft\MorooSoft\Files\HostManager\64Bit\HostManager.exe");
            ViewBag.Message = myFI.FileVersion;
            return View();
        }
    }
}