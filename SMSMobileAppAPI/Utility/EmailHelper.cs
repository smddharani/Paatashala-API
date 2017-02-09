using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Http;

namespace SMSMobileAppAPI.Utility
{
    [AllowAnonymous]
    public class EmailHelper
    {
        [AllowAnonymous]
        public static void TrySendEmail(string emailSubjectText, string emailBodyText, string emailAddress)
        {
            try
            {
                var fromAddress = new MailAddress(" no.reply.softserveglobal@gmail.com", "no-reply@softserveglobal.com");
                var toAddress = new MailAddress(emailAddress, "no-reply@softserveglobal.com");
                const string fromPassword = "ssg@1234";
                string subject = emailSubjectText;
                string body = emailBodyText;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    // DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body,

                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}