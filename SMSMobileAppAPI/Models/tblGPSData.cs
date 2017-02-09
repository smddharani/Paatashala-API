using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblGPSData
    {
        public long Id { get; set; }
        public Nullable<long> RouteCode { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblRoute tblRoute { get; set; }
    }
}
