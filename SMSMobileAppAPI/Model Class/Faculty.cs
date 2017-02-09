using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSMobileAppAPI.Model_Class
{
    public class Faculty
    {
        public List<Faculties> FacultyList { get; set; }
        public Faculty()
        {
            FacultyList = new List<Faculties>();
        }
    }
    public class Faculties
    {
        public string SubjectName { get; set; }
        public string EmployeeName { get; set; }
    }
}