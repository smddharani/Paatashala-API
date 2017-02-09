using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblEmployeeAttachment
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public byte[] Attachment { get; set; }
        public string FileName { get; set; }
        public Nullable<long> FileSizeInBytes { get; set; }
        public long OrgId { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
