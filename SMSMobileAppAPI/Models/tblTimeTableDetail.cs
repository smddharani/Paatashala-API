using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTimeTableDetail
    {
        public long Id { get; set; }
        public Nullable<long> WorkingDays { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTIme { get; set; }
        public Nullable<long> TimeTableId { get; set; }
        public Nullable<long> FacultyId { get; set; }
        public Nullable<long> SubjectId { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblTimeTable tblTimeTable { get; set; }
    }
}
