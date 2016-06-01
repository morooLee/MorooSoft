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
            String path = Request.PhysicalApplicationPath + "/Files/HostManager/HostManager.exe";
            FileVersionInfo myFI = FileVersionInfo.GetVersionInfo(path);
            
            if (version != null)
            {
                if (version == "64")
                {
                    path = Request.PhysicalApplicationPath + "/Files/HostManager/HostManager.exe";
                    myFI = FileVersionInfo.GetVersionInfo(path);

                    return Json(new { version = myFI.FileVersion }, JsonRequestBehavior.AllowGet);
                }
                else if (version == "32")
                {
                    path = Request.PhysicalApplicationPath + "/Files/HostManager/HostManager.exe";
                    myFI = FileVersionInfo.GetVersionInfo(path);

                    return Json(new { version = myFI.FileVersion }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                ViewBag.Message = myFI.FileVersion;
            }

            return View();
        }
    }
}