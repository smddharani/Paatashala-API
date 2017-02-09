using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblTripSheet
    {
        public tblTripSheet()
        {
            this.tblTripParticipants = new List<tblTripParticipant>();
        }

        public long Id { get; set; }
        public Nullable<long> RouteVehicleId { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public bool IsActive { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblRoute_Vehicle tblRoute_Vehicle { get; set; }
        public virtual ICollection<tblTripParticipant> tblTripParticipants { get; set; }
    }
}
