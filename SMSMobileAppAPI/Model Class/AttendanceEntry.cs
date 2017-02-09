using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSMobileAppAPI.Model_Class
{
    public class AttendanceEntry
    {
        public long OrgId { get; set; }
        public DateTime Timestamp { get; set; } 
        public List<scannedStudents> StudentId { get; set; }
    }  
    public class scannedStudents
    {
        public long Id { get; set; }
    }
}