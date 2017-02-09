using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
   
    [RoutePrefix("/School")]
    public class SchoolController : Controller
    {
        webSchoolContext db = new webSchoolContext();
        // GET: StudentSchool

        // GET api/Account/UserInfo
        //[HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]

        [Route("GetAll")]  
        public JsonResult GetAll()
        {
            var schoolList = (from tableSchool in db.tblOrgs
                              select new { tableSchool.Id, tableSchool.OrgName }).ToList();
            return Json(schoolList, JsonRequestBehavior.AllowGet);
        }
    }
}
