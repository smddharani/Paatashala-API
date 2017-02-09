using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblEmployeeLeaveType
    {
        public tblEmployeeLeaveType()
        {
            this.tblEmployeeAttendances = new List<tblEmployeeAttendance>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblEmployeeAttendance> tblEmployeeAttendances { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
