using SMSMobileAppAPI.Model_Class;
using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    public class AssesmentReportController : Controller
    {
        // GET: AssesmentReport
        Assesment Assesmentobj = new Assesment();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetByStudent(long StudentId,long OrgId)
        {
            webSchoolContext db = new webSchoolContext();
            var ReportDetail = (from tableMarks in db.tblExamMarks
                                join tableSubjects in db.tblSubjects on tableMarks.SubjectId equals tableSubjects.Id
                                join tableExamSchedule in db.tblExamSchedules on tableMarks.ExamSchdeduleId equals tableExamSchedule.Id
                                join tableExamtype in db.tblExamTypes on tableExamSchedule.ExamType equals tableExamtype.Id
                                where tableMarks.StudentId == StudentId && tableMarks.OrgId == OrgId
                                select new { tableExamtype.Name, SubjectName = tableSubjects.Name, tableMarks.Marks }).ToList();

            Assesmentobj.Reports = new List<AssesmentList>();
            foreach(var item in ReportDetail)
            {
                var ReportTemp = new AssesmentList();
                Assesmentobj.Reports.Add(ReportTemp);
                ReportTemp.Examtype = item.Name;
                ReportTemp.SubjectName = item.SubjectName;
                ReportTemp.Marks = item.Marks;
            }

            return Json(Assesmentobj, JsonRequestBehavior.AllowGet);
        }
    }
}