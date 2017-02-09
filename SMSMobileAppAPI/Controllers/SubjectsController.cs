using SMSMobileAppAPI.Model_Class;
using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SMSMobileAppAPI.Controllers
{
    [RoutePrefix("/Subjects")]
    public class SubjectsController : Controller
    {
        Subject SubjectObj = new Subject();
        webSchoolContext db = new webSchoolContext();
        [Route("GetAllByStudent")]

        public JsonResult GetAllByStudent(long StudentId)
        {
            try
            {
                var SubjectsData = (from tableSubject in db.tblSubjects
                                join tableCourseSubjects in db.tblCourse_Subject on tableSubject.Id equals tableCourseSubjects.SubjectId
                                join tableBatchAdmission in db.tblBatchAdmissions on tableCourseSubjects.CourseId equals tableBatchAdmission.CourseId
                                join tableTimeTableDetail in db.tblTimeTableDetails on tableSubject.Id equals tableTimeTableDetail.SubjectId
                                join tabletimetable in db.tblTimeTables on tableTimeTableDetail.TimeTableId equals tabletimetable.Id
                                join tableEmployee in db.tblEmployees on tableTimeTableDetail.FacultyId equals tableEmployee.Id
                                where tableBatchAdmission.StudentId == StudentId && tabletimetable.IsActive == true
                                select new { tableSubject.Id, tableSubject.Name,tableEmployee.FirstName }).ToList().Distinct();

                SubjectObj.subjectsList = new List<subjects>();
                foreach(var item in SubjectsData)
                {
                    var subjectTemp = new subjects();
                    SubjectObj.subjectsList.Add(subjectTemp);

                    subjectTemp.Id = item.Id;
                    subjectTemp.SubjectName = item.Name;
                    subjectTemp.EmployeeName = item.FirstName;
                }
                 
                return Json(SubjectObj, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(e.ToString(), JsonRequestBehavior.AllowGet);
            }
        }
    }
}
