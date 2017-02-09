using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblCircular
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> Dated { get; set; }
        public string Notice { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
