using SMSMobileAppAPI.Models;
using SMSMobileAppAPI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    [RoutePrefix("/ForgetPassword")]
    public class ForgetPasswordController : Controller
    {
        // GET: ForgetPassword.
       
        public ActionResult Index()
        {
            return View();
        }
        webSchoolContext db = new webSchoolContext();

        [Route("getPassword")]
        public JsonResult getPassword(string Email)
        {
            string message = string.Empty;
            var Password = "";
            
                var User = db.tblAppLogins.Where(x => x.Email == Email).Select(x => x).SingleOrDefault();
                if (User != null)
                {
                    Password = SMSDataformatter.DecryptText(User.Password);
                    string Body = "<html><body> Hi there! <br /><br /> Your Password is:" + Password + "</body></html>";
                    string subject = "Password";
                    EmailHelper.TrySendEmail(subject, Body, Email);
                    message = string.Format("Password Sent your Email!");
                    return Json(new { status = true, Message = message });
                }
                else
                {
                    message = string.Format("Email Not Exist!");
                    return Json(new { status = false, Message = message });
                }
        }
        private object GetOrgDetails(string orgName)
        {
            return db.tblOrgs.Where(x => x.OrgName.ToLower() == orgName).Select(x => new { OrgId = x.Id, OrgName = x.OrgName }).SingleOrDefault();
        }

        [Route("getEmployeePassword")]

        public JsonResult getEmployeePassword(string Email,string OrgName)
        { 
            var Password = "";
            string message = string.Empty;
            var OrgDetails = GetOrgDetails(OrgName.Trim().ToLower());
            if (OrgDetails != null)
            {
                long loggedUserOrgid = Convert.ToInt64(OrgDetails.GetType().GetProperty("OrgId").GetValue(OrgDetails, null));
                var loggedUser = db.tblLogins.Where(x => x.UserName.ToLower() == Email.ToLower() &&
                       x.OrgId == loggedUserOrgid).Select(x => x).SingleOrDefault();
                if (loggedUser != null)
                {
                    Password = SMSDataformatter.DecryptText(loggedUser.Password);
                    string Body = "<html><body> Hi there! <br /><br /> Your Password is:" + Password + "</body></html>";
                    string subject = "Password";
                    EmailHelper.TrySendEmail(subject, Body, Email);
                    message = string.Format("Password Sent your Email!");
                    return Json(new { status = true, Message = message });
                }
                else
                {
                    message = string.Format("Email Not Exist!");
                    return Json(new { status = false, Message = message });
                }
            }
            else
            {
                message = string.Format("OrgName Not Exist!");
                return Json(new { status = false, Message = message });
            }
        }
    }
}