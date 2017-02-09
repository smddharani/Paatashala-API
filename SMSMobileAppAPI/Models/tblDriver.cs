using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblDriver
    {
        public tblDriver()
        {
            this.tblRoute_Vehicle = new List<tblRoute_Vehicle>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string LicenseNumber { get; set; }
        public Nullable<System.DateTime> LicenseExpiry { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblRoute_Vehicle> tblRoute_Vehicle { get; set; }
    }
}
