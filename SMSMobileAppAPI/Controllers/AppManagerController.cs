using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    public class AppManagerController : Controller
    {
        // GET: AppManager
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetLatestVersion()
        {
            webSchoolContext db = new webSchoolContext();
            var version = db.tblAppVersions.OrderByDescending(x => x.BuidDate).Take(1).ToList().Select(x => new {x.VersionId,BuildDate = x.BuidDate.Value.ToString("dd-MMM-yyyy"),x.Version,x.UpdateMessage,x.Notes}).FirstOrDefault();
            return Json(version,JsonRequestBehavior.AllowGet);
        }
        public FileStreamResult PatashalaApp()
        {
            FileStreamResult fileStreamResult = null;
            var filePath = Server.MapPath("~/Apk/patashala.apk");
            Stream stream = new FileStream(filePath, FileMode.Open);
            fileStreamResult = new FileStreamResult(stream, "application/apk");
            fileStreamResult.FileDownloadName = "Patashala.apk";
            return fileStreamResult;
        }
        public ActionResult UploadAPK()
        {
            return View("~/Views/UploadAPKFile.cshtml");
        }
        [HttpPost]
        public ActionResult SaveAPKFile(HttpPostedFileBase file)
        {

            return View();
        }

    }
}