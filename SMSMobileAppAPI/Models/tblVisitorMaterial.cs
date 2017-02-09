using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblVisitorMaterial
    {
        public long Id { get; set; }
        public string MaterialName { get; set; }
        public Nullable<long> VisitorId { get; set; }
        public Nullable<bool> IsRetuned { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblVisitor tblVisitor { get; set; }
    }
}
