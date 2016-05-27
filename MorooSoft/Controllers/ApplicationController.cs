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
            String path = Request.PhysicalApplicationPath + "/Files/HostManager/64Bit/HostManager.exe";
            FileVersionInfo myFI = FileVersionInfo.GetVersionInfo(path);
            //FileVersionInfo myFI = FileVersionInfo.GetVersionInfo(@"C:\Users\moroo\OneDrive\문서\Visual Studio 2015\Projects\MorooSoft\MorooSoft\Files\HostManager\64Bit\HostManager.exe");
            
            if (version != null)
            {
                return Json(new {version = myFI.FileVersion}, JsonRequestBehavior.AllowGet);
            }
            else
            {
                ViewBag.Message = myFI.FileVersion;
            }
            
            //ViewBag.Message = path;
            return View();
        }

        //public JsonResult HostManager(String version)
        //{
        //    String path = Request.PhysicalApplicationPath + "/Files/HostManager/64Bit/HostManager.exe";
        //    FileVersionInfo myFI = FileVersionInfo.GetVersionInfo(path);
        //    //FileVersionInfo myFI = FileVersionInfo.GetVersionInfo(@"C:\Users\moroo\OneDrive\문서\Visual Studio 2015\Projects\MorooSoft\MorooSoft\Files\HostManager\64Bit\HostManager.exe");
        //    ViewBag.Message = myFI.FileVersion;
        //    //ViewBag.Message = path;

        //    version = myFI.FileVersion;
        //    return Json(version, JsonRequestBehavior.AllowGet);
        //}
    }
}