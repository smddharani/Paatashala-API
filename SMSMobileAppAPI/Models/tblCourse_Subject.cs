using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblCourse_Subject
    {
        public long Id { get; set; }
        public long SubjectId { get; set; }
        public long CourseId { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public long OrgId { get; set; }
        public virtual tblCourse tblCourse { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblSubject tblSubject { get; set; }
    }
}
