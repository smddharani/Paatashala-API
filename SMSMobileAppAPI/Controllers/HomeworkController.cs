using SMSMobileAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMSMobileAppAPI.Model_Class;

namespace SMSMobileAppAPI.Controllers
{
    public class HomeworkController : Controller
    {
        // GET: Homework
        Homework Homeworkobj = new Homework();
        public ActionResult Index()
        {
            return View();
        }
        webSchoolContext db = new webSchoolContext();
        private DateTime ConvertToDateTime(string input)
        {
            DateTime dateTime;
            if (DateTime.TryParse(input, out dateTime))
            {
                return dateTime;
            }
            return DateTime.Now;
        }
        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }
        public JsonResult GetByCourse(long CourseId,long BatchId,long OrgId)
        {
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            var HomeworkDetail = (from tableAssignments in db.tblAssignments
                            join tableAssignmentQuestion in db.tblAssignmentQuestions on tableAssignments.Id equals tableAssignmentQuestion.AssignmentId
                            join tableSubjects in db.tblSubjects on tableAssignments.SubjectId equals tableSubjects.Id
                            where tableAssignments.CourseId == CourseId && tableAssignments.BatchId == BatchId && tableAssignments.OrgId == OrgId && tableAssignments.DateOfAssignment== date
                                  select new { tableAssignments.Id,SubjectId=tableSubjects.Id ,tableSubjects.Name, tableAssignments.DateOfAssignment, tableAssignments.AssignmentName, tableAssignmentQuestion.Question}).ToList();


            Homeworkobj.assignmentsList = new List<assignments>();
            foreach(var temp in HomeworkDetail)
            {
               var HomeTemp = new assignments();
                var Questiontemp = new Questions();
                if (Homeworkobj.assignmentsList.Count() != 0)
                {
                    var stu = Homeworkobj.assignmentsList.Where(x => x.SubjectId == temp.SubjectId).SingleOrDefault();
                    if (stu == null)
                    {
                        HomeTemp.AssignmentId = temp.Id;
                        HomeTemp.SubjectId = temp.SubjectId;
                        HomeTemp.SubjectName = temp.Name;
                        HomeTemp.AssignmentName = temp.AssignmentName;
                        HomeTemp.Date = ConvertToJavascriptDate(new DateTime(temp.DateOfAssignment.Year, temp.DateOfAssignment.Month, temp.DateOfAssignment.Day));
                        Questiontemp.QuestionsName = temp.Question;
                        Homeworkobj.assignmentsList.Add(HomeTemp);
                        HomeTemp.MultipleQuestion.Add(Questiontemp);
                    }
                    else
                    {
                        var stuobj = Homeworkobj.assignmentsList.Where(x => x.SubjectId == temp.SubjectId).SingleOrDefault();
                        Questiontemp.QuestionsName = temp.Question;
                        Homeworkobj.assignmentsList.Remove(Homeworkobj.assignmentsList.Where(x => x.SubjectId == temp.SubjectId).Single());
                        Homeworkobj.assignmentsList.Add(stuobj);
                        stuobj.MultipleQuestion.Add(Questiontemp);
                    }
                }
                else
                {
                    
                    HomeTemp.AssignmentId = temp.Id;
                    HomeTemp.SubjectId = temp.SubjectId;
                    HomeTemp.SubjectName = temp.Name;
                    HomeTemp.AssignmentName = temp.AssignmentName;
                    HomeTemp.Date = ConvertToJavascriptDate(new DateTime(temp.DateOfAssignment.Year, temp.DateOfAssignment.Month, temp.DateOfAssignment.Day));
                    Questiontemp.QuestionsName = temp.Question;
                    Homeworkobj.assignmentsList.Add(HomeTemp);
                    HomeTemp.MultipleQuestion.Add(Questiontemp);

                }
            }

            return Json(Homeworkobj, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetByDate(string Date, long OrgId, long CourseId, long BatchId)
        {
            var datee = ConvertToDateTime(Date);
            DateTime HWDate = new DateTime(datee.Year, datee.Month, datee.Day);
            var Assign = (from tableassignment in db.tblAssignments
                          join tableAssignQuestions in db.tblAssignmentQuestions on tableassignment.Id equals tableAssignQuestions.AssignmentId
                          join tableSubject in db.tblSubjects on tableassignment.SubjectId equals tableSubject.Id
                          where tableassignment.OrgId == OrgId && tableassignment.CourseId == CourseId && tableassignment.BatchId == BatchId &&
                          tableassignment.DateOfAssignment == HWDate
                          select new { tableAssignQuestions.Question, SubjectId=tableSubject.Id ,tableSubject.Name,tableassignment.AssignmentName,tableassignment.DateOfAssignment}).ToList();
            Homeworkobj.assignmentsList = new List<assignments>();
            foreach (var temp in Assign)
            { 
                var HomeTemp = new assignments();
                var Questiontemp = new Questions();
                if (Homeworkobj.assignmentsList.Count() != 0)
                {
                    var stu = Homeworkobj.assignmentsList.Where(x => x.SubjectId == temp.SubjectId).SingleOrDefault();
                    if (stu == null)
                    {
                        HomeTemp.SubjectId = temp.SubjectId;
                        HomeTemp.SubjectName = temp.Name;
                        HomeTemp.AssignmentName = temp.AssignmentName;
                        HomeTemp.Date = ConvertToJavascriptDate(new DateTime(temp.DateOfAssignment.Year, temp.DateOfAssignment.Month, temp.DateOfAssignment.Day));
                        Questiontemp.QuestionsName = temp.Question;
                        Homeworkobj.assignmentsList.Add(HomeTemp);
                        HomeTemp.MultipleQuestion.Add(Questiontemp);
                    }
                    else
                    {
                        var stuobj = Homeworkobj.assignmentsList.Where(x => x.SubjectId == temp.SubjectId).SingleOrDefault();
                        Questiontemp.QuestionsName = temp.Question;
                        Homeworkobj.assignmentsList.Remove(Homeworkobj.assignmentsList.Where(x => x.SubjectId == temp.SubjectId).Single());
                        Homeworkobj.assignmentsList.Add(stuobj);
                        stuobj.MultipleQuestion.Add(Questiontemp);
                    }
                }
                else
                {
                    HomeTemp.SubjectId = temp.SubjectId;
                    HomeTemp.SubjectName = temp.Name;
                    HomeTemp.AssignmentName = temp.AssignmentName;
                    HomeTemp.Date = ConvertToJavascriptDate(new DateTime(temp.DateOfAssignment.Year, temp.DateOfAssignment.Month, temp.DateOfAssignment.Day));
                    Questiontemp.QuestionsName = temp.Question;
                    Homeworkobj.assignmentsList.Add(HomeTemp);
                    HomeTemp.MultipleQuestion.Add(Questiontemp);
                }
            }

            return Json(Homeworkobj, JsonRequestBehavior.AllowGet);
        }
    }
}