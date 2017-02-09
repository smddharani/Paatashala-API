using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentCustomizeValue
    {
        public long Id { get; set; }
        public long FieldId { get; set; }
        public string Value { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
