using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    [RoutePrefix("/PersonalDetail")]
    public class PersonalDetailController : Controller
    {
        // GET: PersonalDetail
        public ActionResult Index()
        {
            return View();
        }

        [Route("GetAllDetail")]
        public JsonResult GetAllDetail(long StudentId,long OrgId)
        {
            webSchoolContext db = new webSchoolContext();
            var Details = (from tableStudent in db.tblStudents
                           join tableStudentRegistration in db.tblStudentRegistrations on tableStudent.Id equals 
                           tableStudentRegistration.StudentId
                           join tableCourse in db.tblCourses on tableStudentRegistration.Course equals tableCourse.Id
                           join tableBatch in db.tblBatches on tableStudentRegistration.Batch equals tableBatch.Id
                           join tableOrg in db.tblOrgs on tableStudent.OrgId equals tableOrg.Id
                           where tableStudent.Id == StudentId && tableStudent.OrgId == OrgId
                           select new { Name = tableStudent.FirstName + " " + tableStudent.MiddleName + " " +
                           tableStudent.LastName,tableOrg.OrgName, tableStudentRegistration.RegistrationCode,
                               Batch = tableBatch.Name, Course = tableCourse.Name}).FirstOrDefault();
            var StudentPhoto = (from StudentTable in db.tblStudents
                                where StudentTable.Id == StudentId && StudentTable.OrgId == OrgId
                                select new { StudentTable.Photo }).SingleOrDefault();
            var URLImage = string.Empty;
            if (StudentPhoto.Photo!=null)
            {
                var PhotoString = Convert.ToBase64String(StudentPhoto.Photo);
                URLImage= "data:image/png;base64," + PhotoString;
            }
            return Json(new { Details, URLImage },JsonRequestBehavior.AllowGet);
        }
        [Route("GetEmployeeDetail")]
        public JsonResult GetEmployeeDetail(long EmployeeId,long OrgId) 
        {
            webSchoolContext db = new webSchoolContext();
            var Data = (from EmployeeTable in db.tblEmployees
                        join DesignationTable in db.tblDesignations on EmployeeTable.Designation equals DesignationTable.Id
                             into joinedDesignation from DesignationTable in joinedDesignation.DefaultIfEmpty()
                        where EmployeeTable.Id == EmployeeId && EmployeeTable.OrgId == OrgId
                        select new {Name= EmployeeTable.FirstName+" "+ EmployeeTable.MiddleName+" "+ EmployeeTable.LastName,
                            EmployeeTable.EmpId,Designation = DesignationTable.Name}).FirstOrDefault();
            return Json(new {Data},JsonRequestBehavior.AllowGet);
        }
    }
}