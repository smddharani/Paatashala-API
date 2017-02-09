using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblInstitution
    {
        public tblInstitution()
        {
            this.tblBranches = new List<tblBranch>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string AdminContact { get; set; }
        public string Country { get; set; }
        public string CurrencyType { get; set; }
        public string InstittuionCode { get; set; }
        public string TimeZone { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual ICollection<tblBranch> tblBranches { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
