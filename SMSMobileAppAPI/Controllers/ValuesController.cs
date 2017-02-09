using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SMSMobileAppAPI.Controllers
{
    [AllowAnonymous]
    public class ValuesController : ApiController
    {
        webSchoolContext db = new webSchoolContext();

        [Route("GetA")]
        public IEnumerable<string> GetA(string Username, string Password)
        {
            try
            {
                var data = (from tableLogin in db.tblLogins
                            where tableLogin.UserName == Username
                            select tableLogin).SingleOrDefault();
                if (data != null)
                {
                    if (SMSDataformatter.DecryptText(data.Password) == Password)
                    {

                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
            return new string[] { "value1", "value2" };
        }
        [ActionName("GetA")]
        [HttpGet]
        public IEnumerable<string> GetB(string Username, string Password)
        {

            return new string[] { "value1", "value2" };
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
