using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    [RoutePrefix("/Batch")]
    public class BatchController : Controller
    {
        webSchoolContext db = new webSchoolContext();
        [Route("GetAllByOrg")]
        public JsonResult GetAllByOrg(long OrgId)
        {
            try
            {
                var Course = (from tb in db.tblBatches
                              where tb.OrgId == OrgId
                              select new { tb.Id, tb.Name }).ToList();
                return Json(Course, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                return Json(e.ToString(), JsonRequestBehavior.AllowGet);
            }
        }
        
    }
}