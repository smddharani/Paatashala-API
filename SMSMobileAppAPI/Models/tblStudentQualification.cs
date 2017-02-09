using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentQualification
    {
        public long Id { get; set; }
        public Nullable<long> StudentId { get; set; }
        public string SchoolName { get; set; }
        public string ClassOrCourse { get; set; }
        public Nullable<System.DateTime> YearPassed { get; set; }
        public Nullable<long> Percentage { get; set; }
        public long ReasonForExit { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudent tblStudent { get; set; }
        public virtual tblStudentPrevQualificationReason tblStudentPrevQualificationReason { get; set; }
    }
}
