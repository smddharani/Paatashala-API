using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblRole
    {
        public tblRole()
        {
            this.tblEmployees = new List<tblEmployee>();
            this.tblRolePermissions = new List<tblRolePermission>();
        }

        public long Id { get; set; }
        public string RoleName { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblRolePermission> tblRolePermissions { get; set; }
    }
}
