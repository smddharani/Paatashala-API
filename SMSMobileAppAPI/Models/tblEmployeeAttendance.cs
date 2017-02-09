using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblEmployeeAttendance
    {
        public long Id { get; set; }
        public long EmpId { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsPresent { get; set; }
        public Nullable<long> LeaveType { get; set; }
        public long OrgId { get; set; }
        public virtual tblEmployeeLeaveType tblEmployeeLeaveType { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblOrg tblOrg1 { get; set; }
    }
}
