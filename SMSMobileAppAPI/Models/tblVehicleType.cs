using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblVehicleType
    {
        public tblVehicleType()
        {
            this.tblVehicles = new List<tblVehicle>();
        }

        public long Id { get; set; }
        public string TypeName { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblVehicle> tblVehicles { get; set; }
    }
}
