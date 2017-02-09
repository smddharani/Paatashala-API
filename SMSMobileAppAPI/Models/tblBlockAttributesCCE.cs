using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblBlockAttributesCCE
    {
        public long Id { get; set; }
        public long AttributeValue { get; set; }
        public string AttributeName { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
