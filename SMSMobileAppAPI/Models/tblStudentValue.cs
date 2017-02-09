using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentValue
    {
        public long Id { get; set; }
        public Nullable<long> FieldId { get; set; }
        public string Value { get; set; }
        public long StudentId { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}
