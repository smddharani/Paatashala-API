using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblDesignation
    {
        public tblDesignation()
        {
            this.tblEmployees = new List<tblEmployee>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
