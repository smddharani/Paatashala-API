using SMSMobileAppAPI.Models;
using SMSMobileAppAPI.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    [RoutePrefix("/ParentRegistration")]
    public class ParentRegistrationController : Controller
    {
        // GET: Register

        public ActionResult Index()
        {
            return View();
        }
        webSchoolContext db = new webSchoolContext();
        tblAppLogin tblAppLoginobj = new tblAppLogin();
        [Route("SendEmailVerificationCode")]
        public JsonResult SendEmailVerificationCode(string Email)
        {
            try
            {
                string message = string.Empty;
                var HasStudent = db.tblStudents.Where(x => x.FatherEmail == Email || x.MotherEmail == Email).Select(u => u.StudentId).ToList();
                if (HasStudent.Count != 0)
                {
                    var HasDuplicate = db.tblAppLogins.Where(x => x.Email == Email && x.IsRegistered == true).Select(x => new { x.Email }).SingleOrDefault();
                    if (HasDuplicate == null)
                    {
                        var Duplicate = db.tblAppLogins.Where(x => x.Email == Email).SingleOrDefault();
                        if (Duplicate == null)
                        {
                            tblAppLoginobj.Email = Email;
                            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                            Random rand = new Random();
                            int size = 6;
                            StringBuilder Passcode = new StringBuilder();
                            char[] chars = new char[size];
                            for (int i = 0; i < size; i++)
                            {
                                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
                                Passcode.Append(chars[i]);
                            }
                            tblAppLoginobj.IsRegistered = false;
                            tblAppLoginobj.Passcode = Passcode.ToString();
                            db.tblAppLogins.Add(tblAppLoginobj);
                            db.SaveChanges();
                            string Body = "<html><body> Hi there! <br /><br /> Your Verification Code is:" + Passcode + "</body></html>";
                            string subject = "Verification Code";
                            EmailHelper.TrySendEmail(subject, Body, Email);
                            return Json(new { status = true },JsonRequestBehavior.AllowGet);
                        }
                        else
                        {
                            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                            Random rand = new Random();
                            int size = 6;
                            StringBuilder Passcode = new StringBuilder();
                            char[] chars = new char[size];
                            for (int i = 0; i < size; i++)
                            {
                                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
                                Passcode.Append(chars[i]);
                            }
                            tblAppLoginobj.IsRegistered = false;
                            Duplicate.Passcode = Passcode.ToString();
                            tblAppLoginobj.Passcode = Passcode.ToString();
                            db.Entry(Duplicate).State = EntityState.Modified;
                            db.SaveChanges();
                            string Body = "<html><body> Hi there! <br /><br /> Your Verification Code is:" + Passcode + "</body></html>";
                            string subject = "Verification Code";
                            EmailHelper.TrySendEmail(subject, Body, Email);
                            return Json(new { status = true }, JsonRequestBehavior.AllowGet);
                        }
                    }
                    else
                    {
                        message = string.Format("Already Registered!");
                        return Json(new { status = false, Message = message }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    message = string.Format("Email Not Saved As Parents Email");
                    return Json(new { status = false, Message = message }, JsonRequestBehavior.AllowGet);
                }

            }
            catch (Exception e)
            {
                return Json(new { status = false, Message = e.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult VerifyCode(string Passcode, string Email)
        {
            string message = string.Empty;
            var Code = (from tableAppLogin in db.tblAppLogins
                        where tableAppLogin.Email == Email && tableAppLogin.Passcode == Passcode
                        select tableAppLogin).SingleOrDefault();
            if (Code != null)
            {
                return Json(new { status = true });
            }
            else
            {
                message = string.Format("Passcode is Not Valid");
                return Json(new { status = false, Message = message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult SavePassword(string Email, string Password)
        {
            //var HasStudents = (from StudentTable in db.tblStudents
            //                   join StudentRegistration in db.tblStudentRegistrations on StudentTable.Id equals StudentRegistration.StudentId
            //                   where StudentTable.FatherEmail == Email || StudentTable.MotherEmail == Email
            //                   select new
            //                   {
            //                       StudentTable.Id,
            //                       Name = StudentTable.FirstName + " " + StudentTable.MiddleName + " " +
            //                   StudentTable.LastName,
            //                       StudentRegistration.RegistrationCode,
            //                       StudentRegistration.Course,
            //                       StudentRegistration.Batch,
            //                       StudentTable.OrgId,
            //                       StudentTable.FatherName,
            //                       StudentTable.Sex
            //                   }).ToList();

            var User = (from tableApplogin in db.tblAppLogins
                        where tableApplogin.Email == Email
                        select tableApplogin).FirstOrDefault();
            if (User != null)
            {

                User.Password = SMSDataformatter.EncryptText(Password);
                User.IsRegistered = true;
                db.Entry(User).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { status = true /*Students = HasStudents */}, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = false }, JsonRequestBehavior.AllowGet);
            }

        }
    }
}