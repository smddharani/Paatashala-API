using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSMobileAppAPI.Controllers
{
    public class TimetableController : Controller
    {
        
       public JsonResult GetByCourse(long BatchId,long CourseId,long OrgId)
        {
            webSchoolContext db = new webSchoolContext();
            try
            {
                TimeTableStructure structureObj = new TimeTableStructure();
                var timeTable = db.tblTimeTables.Where(t => t.Batch == BatchId && t.Course == CourseId && t.IsActive == true && t.OrgId == OrgId).FirstOrDefault();
                var timetableWorkingDays = (from tt in db.tblTimeTables
                                            join tw in db.tblTimetable_workingDays on tt.Id equals tw.TimetableId
                                            where tt.Course == CourseId && tt.Batch == BatchId && tt.OrgId == OrgId &&tt.IsActive == true
                                            select tw).FirstOrDefault();
                if (timetableWorkingDays != null)
                {
                    structureObj.Name = timeTable.Name;
                    structureObj.Id = timeTable.Id;
                    AddTimeTableStructure(timeTable.Id, structureObj, timetableWorkingDays);
                    return Json(structureObj, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json("Working days not set.", JsonRequestBehavior.AllowGet);
                }
            }
            catch(Exception e)
            {
                return Json(e, JsonRequestBehavior.AllowGet);
            }
        }

        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }

        private void AddTimeTableStructure(long id, TimeTableStructure structureObj, tblTimetable_workingDays timetableWorkingDays)
        {
            webSchoolContext db = new webSchoolContext();

            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.SUNDAY).First().Visible = timetableWorkingDays.Sunday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.MONDAY).First().Visible = timetableWorkingDays.Monday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.TUESDAY).First().Visible = timetableWorkingDays.Tuesday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.WEDNESDAY).First().Visible = timetableWorkingDays.Wednesday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.THURSDAY).First().Visible = timetableWorkingDays.Thrusday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.FRIDAY).First().Visible = timetableWorkingDays.Friday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.SATARDAY).First().Visible = timetableWorkingDays.Saturday ?? false;

            var periods = (from td in db.tblTimeTableDetails
                           join tt in db.tblTimeTables on td.TimeTableId equals tt.Id
                           where tt.Id == id
                           select td).ToList();

            foreach (var item in periods)
            {
                var f = db.tblEmployees.Where(e => e.Id == item.FacultyId).FirstOrDefault();
                var subject = db.tblSubjects.Where(s => s.Id == item.SubjectId).FirstOrDefault();
                structureObj.WeekdayTimeTables.Where(w => (int)w.WeekdayName == (int)item.WorkingDays).First().Periods.Add(new Period()
                {
                    Subject = subject != null ? new TimeTableSubject() { Name = subject.Name, Id = subject.Id } : new TimeTableSubject() { Name = "BREAK", Id = 0 },
                    StartTime = ConvertToJavascriptDate(new DateTime(1970, 1, 1, item.StartTime.Value.Hours,item.StartTime.Value.Minutes,item.StartTime.Value.Seconds )),
                    EndTime = ConvertToJavascriptDate(new DateTime(1970, 1, 1, item.EndTIme.Value.Hours, item.EndTIme.Value.Minutes, item.EndTIme.Value.Seconds)),
                    Id = item.Id,
                    FacultyName = f.FirstName + " " + f.LastName,
                    FacultyId = f.Id
                });
            }
        }
    }
}