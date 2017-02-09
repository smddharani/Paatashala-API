using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblRouteStop
    {
        public tblRouteStop()
        {
            this.tblRoute_Stops = new List<tblRoute_Stops>();
        }

        public long Id { get; set; }
        public string StopName { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblRoute_Stops> tblRoute_Stops { get; set; }
    }
}
