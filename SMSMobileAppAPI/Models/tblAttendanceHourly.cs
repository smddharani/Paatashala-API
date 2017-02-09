using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAttendanceHourly
    {
        public long Id { get; set; }
        public long StudentId { get; set; }
        public System.TimeSpan Time { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<bool> IsPickUp { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}
