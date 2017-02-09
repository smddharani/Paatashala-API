using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblVisitor
    {
        public tblVisitor()
        {
            this.tblVisitorMaterials = new List<tblVisitorMaterial>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string VehicleNumber { get; set; }
        public Nullable<long> ToMeet { get; set; }
        public Nullable<long> PersonType { get; set; }
        public string Reason { get; set; }
        public Nullable<long> VechicleType { get; set; }
        public Nullable<System.TimeSpan> InTime { get; set; }
        public Nullable<System.TimeSpan> OutTime { get; set; }
        public long OrgId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblVisitorMaterial> tblVisitorMaterials { get; set; }
    }
}
