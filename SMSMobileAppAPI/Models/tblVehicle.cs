using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblVehicle
    {
        public tblVehicle()
        {
            this.tblRoute_Vehicle = new List<tblRoute_Vehicle>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long TypeId { get; set; }
        public string Description { get; set; }
        public string ChassisNumber { get; set; }
        public string RegistrationNo { get; set; }
        public long SeartingCapacity { get; set; }
        public string ContactPerson { get; set; }
        public string InsuranceNo { get; set; }
        public System.DateTime InsuranceRenewalDate { get; set; }
        public string RCNumber { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblRoute_Vehicle> tblRoute_Vehicle { get; set; }
        public virtual tblVehicleType tblVehicleType { get; set; }
    }
}
