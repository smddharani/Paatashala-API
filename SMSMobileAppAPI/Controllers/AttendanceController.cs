using SMSMobileAppAPI.Model_Class;
using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    public class AttandanceController : Controller
    {
        webSchoolContext DbContext = new webSchoolContext();
        // GET: Attandance
        public ActionResult Index()
        {
            return View();
        }

        private DateTime ConvertToDateTime(string input)
        {
            DateTime dateTime;
            if (DateTime.TryParse(input, out dateTime))
            {
                return dateTime;
            }
            return DateTime.Now;
        }

        public JsonResult getStudentsList(long OrgId)
        {
            var AdmStudents = (from tableStudent in DbContext.tblStudents
                               join tableBatchAdmission in DbContext.tblBatchAdmissions on tableStudent.Id equals tableBatchAdmission.StudentId
                               where tableBatchAdmission.OrgId == OrgId && tableStudent.IsLead == false
                               select new { Name = tableStudent.FirstName + " " + tableStudent.MiddleName + " " + tableStudent.LastName, tableStudent.Id,tableStudent.StudentId}).ToList();
            return Json(new { AdmStudents }, JsonRequestBehavior.AllowGet); 
        }

        public JsonResult SaveAttendance(long OrgId,string StudentId,string scanDateTime,bool IsPicUp)
        {
            string Status = string.Empty;
            string message = string.Empty;
            try
            {
                var datee = ConvertToDateTime(scanDateTime);
                string[] arrlong = StudentId.Split(',');
                foreach (var temp in arrlong)
                {
                    DbContext.tblAttendanceHourlies.Add(new tblAttendanceHourly()
                    {
                        StudentId = Convert.ToInt64(temp),
                        IsPickUp = IsPicUp,
                        Time = new TimeSpan(datee.Hour, datee.Minute, datee.Second),
                        Date = new DateTime(datee.Year, datee.Month, datee.Day),
                        OrgId = OrgId
                    });
                    DbContext.SaveChanges();
                    var Student = DbContext.tblStudents.Where(x => x.Id.ToString() == StudentId).Select(y => y).FirstOrDefault();
                    string Number = "+91" + Student.ContactNo;
                    string Username = "sftg-softserve";
                    string Password = "soft123";
                    string Source = "SSGBLR";
                    if(IsPicUp == true) { Status = "Pickedup"; }
                    if(IsPicUp == false) {Status = "Dropped"; }

                    string Content ="Its Here By To Notify Your Kid Master. "+ Student.FirstName + " " + Student.MiddleName + " " + Student.LastName + " " +"Has "+  Status;

                    string strUrl = "http://103.16.101.52:8080/sendsms/bulksms?username=" + Username + "&password=" + Password + "&type=0&dlr=1&destination=" + Number + "&source=" + Source + "&message=" + Content;
                    HttpWebRequest _createRequest = (HttpWebRequest)WebRequest.Create(strUrl);
                    HttpWebResponse response = (HttpWebResponse)_createRequest.GetResponse();
                    Stream s = (Stream)response.GetResponseStream();
                    StreamReader readStream = new StreamReader(s);
                    string dataString = readStream.ReadToEnd();
                    response.Close();
                    s.Close();
                    readStream.Close();
                }
                return Json(new {status=true }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                return Json(new {status=false ,message=e.ToString() }, JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}