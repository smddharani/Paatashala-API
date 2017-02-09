using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblExamMark
    {
        public long Id { get; set; }
        public long ExamSchdeduleId { get; set; }
        public long SubjectId { get; set; }
        public long StudentId { get; set; }
        public decimal Marks { get; set; }
        public long OrgId { get; set; }
        public virtual tblExamSchedule tblExamSchedule { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudent tblStudent { get; set; }
        public virtual tblSubject tblSubject { get; set; }
    }
}
