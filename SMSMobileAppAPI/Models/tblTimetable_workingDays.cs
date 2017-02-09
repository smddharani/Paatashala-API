using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTimetable_workingDays
    {
        public long Id { get; set; }
        public Nullable<bool> Sunday { get; set; }
        public Nullable<bool> Monday { get; set; }
        public Nullable<bool> Tuesday { get; set; }
        public Nullable<bool> Wednesday { get; set; }
        public Nullable<bool> Thrusday { get; set; }
        public Nullable<bool> Friday { get; set; }
        public Nullable<bool> Saturday { get; set; }
        public Nullable<long> TimetableId { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
