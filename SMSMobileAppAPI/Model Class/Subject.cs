using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSMobileAppAPI.Model_Class
{
    public class Subject
    {
        public List<subjects> subjectsList { get; set; }
        public Subject()
        {
            subjectsList = new List<subjects>();
        }
    }
    public class subjects
    {
        public long Id { get; set; }
        public string SubjectName { get; set; }
        public string EmployeeName { get; set; }
    }
}