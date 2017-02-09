using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblEvent
    {
        public long Id { get; set; }
        public Nullable<long> EmpId { get; set; }
        public string EventName { get; set; }
        public Nullable<long> EventType { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ContactPerson { get; set; }
        public long OrgId { get; set; }
        public virtual tblEventType tblEventType { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
