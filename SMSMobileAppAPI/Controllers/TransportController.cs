using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    [RoutePrefix("/Transport")]
    public class TransportController : Controller
    {
        webSchoolContext db = new webSchoolContext();

        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }

        [Route("GetAllByStudent")]
        public JsonResult GetAllByStudent(long StudentId,long OrgId)
        {
            string PickupTime;
            string DropTime;
            var Transport = (from tableTransport in db.tblTransportTripSheets
                             join tableRoute in db.tblRoutes on tableTransport.RouteId equals tableRoute.Id
                             join tableRouteStops in db.tblRouteStops on tableRoute.RouteStart equals tableRouteStops.Id
                             join temptableRouteStops in db.tblRouteStops on tableRoute.RouteEnd equals temptableRouteStops.Id
                             where tableTransport.StudentId == StudentId && tableTransport.OrgId == OrgId
                             select new { tableTransport.PickTime, tableTransport.DropTime, tableRouteStops.StopName, Endpoint = temptableRouteStops.StopName }).SingleOrDefault();

            PickupTime = ConvertToJavascriptDate(new DateTime(Transport.PickTime.Year, Transport.PickTime.Month, Transport.PickTime.Day, Transport.PickTime.Hour, Transport.PickTime.Minute, Transport.PickTime.Second));
            DropTime = ConvertToJavascriptDate(new DateTime(Transport.DropTime.Year, Transport.DropTime.Month, Transport.DropTime.Day, Transport.DropTime.Hour, Transport.DropTime.Minute, Transport.DropTime.Second));
            return Json(new { Transport, PickupTime, DropTime } ,JsonRequestBehavior.AllowGet);
        }
    }
}