using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblExamSchedule
    {
        public tblExamSchedule()
        {
            this.tblExamMarks = new List<tblExamMark>();
        }

        public long Id { get; set; }
        public Nullable<long> ExamType { get; set; }
        public Nullable<long> SubjectId { get; set; }
        public Nullable<long> BatchId { get; set; }
        public Nullable<long> CourseId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public Nullable<long> Faculty { get; set; }
        public Nullable<long> ExamHall { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public long OrgId { get; set; }
        public virtual tblBatch tblBatch { get; set; }
        public virtual tblCourse tblCourse { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblExamHall tblExamHall { get; set; }
        public virtual ICollection<tblExamMark> tblExamMarks { get; set; }
        public virtual tblExamType tblExamType { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblSubject tblSubject { get; set; }
    }
}
