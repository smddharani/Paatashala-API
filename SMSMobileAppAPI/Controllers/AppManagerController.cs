using System;
using System.Collections.Generic;
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
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult PatashalaApp()
        {
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}