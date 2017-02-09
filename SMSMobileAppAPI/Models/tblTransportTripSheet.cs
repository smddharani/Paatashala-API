using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTransportTripSheet
    {
        public long Id { get; set; }
        public long RouteId { get; set; }
        public long StudentId { get; set; }
        public System.DateTime PickTime { get; set; }
        public System.DateTime DropTime { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblRoute tblRoute { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}
