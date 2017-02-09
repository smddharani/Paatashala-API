using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblRolePermission
    {
        public long Id { get; set; }
        public long MasterPermissionValue { get; set; }
        public long RoleId { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblRole tblRole { get; set; }
    }
}
