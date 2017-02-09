using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentAttachment
    {
        public long Id { get; set; }
        public long StudentId { get; set; }
        public string FileName { get; set; }
        public Nullable<long> FileSizeInBytes { get; set; }
        public byte[] Attachment { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}
