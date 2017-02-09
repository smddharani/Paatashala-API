using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSMobileAppAPI.Model_Class
{
    public class Homework
    {
        public List<assignments> assignmentsList { get; set; }
        public Homework()
        {
            assignmentsList = new List<assignments>();
        }
    }
    public class assignments
    {
        public long AssignmentId { get; set; }
        public string AssignmentName { get; set; }
        public long SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Date { get; set; }
        public List<Questions> MultipleQuestion { get; set; }
        public assignments()
        {
            MultipleQuestion = new List<Questions>();
        }
    }
    public class Questions
    {
        public string QuestionsName { get; set; }
    }
}