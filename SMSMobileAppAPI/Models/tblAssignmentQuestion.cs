using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAssignmentQuestion
    {
        public long Id { get; set; }
        public long AssignmentId { get; set; }
        public string Question { get; set; }
        public long OrgId { get; set; }
        public virtual tblAssignment tblAssignment { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
