using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMSMobileAppAPI.Model_Class;

namespace SMSMobileAppAPI.Controllers
{
    [RoutePrefix("/Holiday")]
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult Index()
        {
            return View();
        }
        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }
        [Route("GetAll")]
        public JsonResult GetAll(long OrgId)
        {
            Holiday Holidayobj = new Holiday();
            var Year = DateTime.Now.Year;
            webSchoolContext db = new webSchoolContext();
            var Holidays = (from tableHoliday in db.tblHolidayLists
                            where tableHoliday.Date.Value.Year == Year && tableHoliday.OrgId == OrgId
                            select new { Date=tableHoliday.Date.ToString(), tableHoliday.Name }).ToList().OrderBy(o => o.Date);

            //Holidayobj.HolidaysList = new List<days>();
            //foreach (var temp in Holidays)
            //{
            //    var HolidayTemp = new days();
            //    Holidayobj.HolidaysList.Add(HolidayTemp);
            //    HolidayTemp.Name = temp.Name;
            //    if (temp.Date != null)
            //    {
            //        HolidayTemp.Date = ConvertToJavascriptDate(new DateTime (temp.Date.Value.Year, temp.Date.Value.Month, temp.Date.Value.Day));
            //    }
            //}

            return Json(new { Holidays}, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEmployeeHolidays(long OrgId)
        {
            webSchoolContext db = new webSchoolContext();
            var Year = DateTime.Now.Year;
            var Holidays = (from tableHoliday in db.tblHolidayLists
                            where tableHoliday.Date.Value.Year == Year && tableHoliday.OrgId == OrgId
                            select new { Date = tableHoliday.Date.ToString(), tableHoliday.Name }).ToList().OrderBy(o => o.Date);
            return Json(new {Holidays},JsonRequestBehavior.AllowGet);
        }
    }
}