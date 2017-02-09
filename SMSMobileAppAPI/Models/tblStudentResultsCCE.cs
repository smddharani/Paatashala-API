using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentResultsCCE
    {
        public long Id { get; set; }
        public long StudentId { get; set; }
        public Nullable<long> TermId { get; set; }
        public Nullable<long> FAId { get; set; }
        public Nullable<long> BlockId { get; set; }
        public Nullable<long> SubBlockId { get; set; }
        public Nullable<long> LearnoMeterId { get; set; }
        public Nullable<long> SAId { get; set; }
        public Nullable<long> CourseId { get; set; }
        public Nullable<long> BatchId { get; set; }
        public Nullable<long> ExamId { get; set; }
        public Nullable<long> SubjectId { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
