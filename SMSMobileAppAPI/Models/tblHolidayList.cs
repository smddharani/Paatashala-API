using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblHolidayList
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
