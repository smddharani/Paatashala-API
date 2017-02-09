using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMSMobileAppAPI.Model_Class;

namespace SMSMobileAppAPI.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Index()
        {
            return View();
        }

        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }
        Exam Examobj = new Exam();
        public JsonResult GetByCourse(long BatchId,long CourseId,long OrgId)
        {
            webSchoolContext db = new webSchoolContext();
            var ExamDetails = (from tableExamSchedule in db.tblExamSchedules
                               join tableExamType in db.tblExamTypes on tableExamSchedule.ExamType equals tableExamType.Id
                               join tableSubjects in db.tblSubjects on tableExamSchedule.SubjectId equals tableSubjects.Id
                               where tableExamSchedule.BatchId == BatchId && tableExamSchedule.CourseId == CourseId && tableExamSchedule.OrgId == OrgId
                               select new { tableExamType.Name, SubjectName = tableSubjects.Name,Date=tableExamSchedule.Date.ToString(), Duration=tableExamSchedule.Duration.ToString(),Starttime=tableExamSchedule.StartTime.ToString()}).ToList().OrderByDescending(D => D.Date);

            //Examobj.ExamSchedule = new List<examList>();
            //foreach(var item in ExamDetails)
            //{
            //    var ExamTemp = new examList();
            //    Examobj.ExamSchedule.Add(ExamTemp);
            //    ExamTemp.Examtype = item.Name;
            //    ExamTemp.SubjectName = item.SubjectName;
            //    ExamTemp.ExamDate= ConvertToJavascriptDate(new DateTime(item.Date.Value.Year, item.Date.Value.Month, item.Date.Value.Day));
            //    ExamTemp.Starttime = ConvertToJavascriptDate(new DateTime(1970, 1, 1, item.StartTime.Value.Hours, item.StartTime.Value.Minutes, item.StartTime.Value.Seconds));
            //    ExamTemp.Duration = ConvertToJavascriptDate(new DateTime(1970, 1, 1, item.Duration.Value.Hours, item.Duration.Value.Minutes, item.Duration.Value.Seconds));

            //}

            return Json(new { ExamDetails }, JsonRequestBehavior.AllowGet);
        }
    }
}