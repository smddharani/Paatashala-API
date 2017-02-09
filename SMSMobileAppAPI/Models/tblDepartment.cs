using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblDepartment
    {
        public tblDepartment()
        {
            this.tblEmployees = new List<tblEmployee>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsTeaching { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
