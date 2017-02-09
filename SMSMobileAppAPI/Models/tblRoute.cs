using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblRoute
    {
        public tblRoute()
        {
            this.tblGPSDatas = new List<tblGPSData>();
            this.tblRoute_Stops = new List<tblRoute_Stops>();
            this.tblRoute_Vehicle = new List<tblRoute_Vehicle>();
            this.tblTransportTripSheets = new List<tblTransportTripSheet>();
        }

        public long Id { get; set; }
        public string RouteCode { get; set; }
        public Nullable<long> RouteStart { get; set; }
        public Nullable<long> RouteEnd { get; set; }
        public Nullable<System.TimeSpan> TotalDuration { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual ICollection<tblGPSData> tblGPSDatas { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblRoute_Stops> tblRoute_Stops { get; set; }
        public virtual ICollection<tblRoute_Vehicle> tblRoute_Vehicle { get; set; }
        public virtual ICollection<tblTransportTripSheet> tblTransportTripSheets { get; set; }
    }
}
