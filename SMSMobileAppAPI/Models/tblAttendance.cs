using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAttendance
    {
        public long Id { get; set; }
        public Nullable<long> StudentId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> P1 { get; set; }
        public Nullable<bool> P2 { get; set; }
        public Nullable<bool> P3 { get; set; }
        public Nullable<bool> P4 { get; set; }
        public Nullable<bool> P5 { get; set; }
        public Nullable<bool> P6 { get; set; }
        public Nullable<bool> P7 { get; set; }
        public Nullable<bool> P8 { get; set; }
        public Nullable<bool> P9 { get; set; }
        public Nullable<bool> P10 { get; set; }
        public Nullable<long> TimeTableId { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}
