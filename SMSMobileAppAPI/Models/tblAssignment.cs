using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAssignment
    {
        public tblAssignment()
        {
            this.tblAssignmentQuestions = new List<tblAssignmentQuestion>();
        }

        public long Id { get; set; }
        public long CourseId { get; set; }
        public long BatchId { get; set; }
        public long SubjectId { get; set; }
        public string AssignmentName { get; set; }
        public System.DateTime DateOfAssignment { get; set; }
        public long OrgId { get; set; }
        public virtual tblBatch tblBatch { get; set; }
        public virtual tblCourse tblCourse { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblSubject tblSubject { get; set; }
        public virtual ICollection<tblAssignmentQuestion> tblAssignmentQuestions { get; set; }
    }
}
