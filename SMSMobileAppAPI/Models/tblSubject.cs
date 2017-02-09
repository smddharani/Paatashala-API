using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblSubject
    {
        public tblSubject()
        {
            this.tblAssignments = new List<tblAssignment>();
            this.tblCourse_Subject = new List<tblCourse_Subject>();
            this.tblExamMarks = new List<tblExamMark>();
            this.tblExamSchedules = new List<tblExamSchedule>();
            this.tblTopics = new List<tblTopic>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblAssignment> tblAssignments { get; set; }
        public virtual ICollection<tblCourse_Subject> tblCourse_Subject { get; set; }
        public virtual ICollection<tblExamMark> tblExamMarks { get; set; }
        public virtual ICollection<tblExamSchedule> tblExamSchedules { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblTopic> tblTopics { get; set; }
    }
}
