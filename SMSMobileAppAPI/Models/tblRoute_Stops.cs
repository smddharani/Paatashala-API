using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblRoute_Stops
    {
        public long Id { get; set; }
        public long RouteId { get; set; }
        public long StopId { get; set; }
        public Nullable<int> RouteOrder { get; set; }
        public Nullable<System.TimeSpan> ArrivalTime { get; set; }
        public Nullable<System.TimeSpan> DepartureTime { get; set; }
        public bool IsRouteStart { get; set; }
        public bool IsRouteEnd { get; set; }
        public Nullable<int> DistanceFromStart { get; set; }
        public Nullable<int> DistanceToEnd { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblRoute tblRoute { get; set; }
        public virtual tblRouteStop tblRouteStop { get; set; }
    }
}
