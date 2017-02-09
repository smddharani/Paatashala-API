using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    [RoutePrefix("/Course")]
    public class CourseController : Controller
    {
        // GET: Course
        webSchoolContext db = new webSchoolContext();
        public ActionResult Index()
        {
            return View();
        }
        [Route("GetAllByOrg")]
        public JsonResult GetAllByOrg(long OrgId)
        {
            try
            {
                var Course = (from tableCourse in db.tblCourses
                              where tableCourse.OrgId == OrgId
                              select new { tableCourse.Id, tableCourse.Name }).ToList();
                return Json(Course, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                return Json(e.ToString(), JsonRequestBehavior.AllowGet);
            }
        }
        
    }
}