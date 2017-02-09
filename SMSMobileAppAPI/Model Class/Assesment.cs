using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSMobileAppAPI.Model_Class
{
    public class Assesment
    {

        public List<AssesmentList> Reports { get; set; }
        public Assesment()
        {
            Reports = new List<AssesmentList>();
        }
    }
    public class AssesmentList
    {
        public string Examtype { get; set; }
        public string SubjectName { get; set; }
        public decimal Marks { get; set; }
    }
}