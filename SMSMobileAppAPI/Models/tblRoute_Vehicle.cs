using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblRoute_Vehicle
    {
        public tblRoute_Vehicle()
        {
            this.tblTripSheets = new List<tblTripSheet>();
        }

        public long Id { get; set; }
        public Nullable<long> RouteId { get; set; }
        public Nullable<long> VehicleId { get; set; }
        public Nullable<long> DriverId { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblDriver tblDriver { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblRoute tblRoute { get; set; }
        public virtual tblVehicle tblVehicle { get; set; }
        public virtual ICollection<tblTripSheet> tblTripSheets { get; set; }
    }
}
