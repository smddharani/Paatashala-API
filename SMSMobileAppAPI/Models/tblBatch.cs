using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblBatch
    {
        public tblBatch()
        {
            this.tblAssignments = new List<tblAssignment>();
            this.tblBatchAdmissions = new List<tblBatchAdmission>();
            this.tblBatchAdmissions1 = new List<tblBatchAdmission>();
            this.tblBatchAdmissionArchives = new List<tblBatchAdmissionArchive>();
            this.tblBatchAdmissionArchives1 = new List<tblBatchAdmissionArchive>();
            this.tblBatchAdmissionPasts = new List<tblBatchAdmissionPast>();
            this.tblCourseFeeDetails = new List<tblCourseFeeDetail>();
            this.tblExamSchedules = new List<tblExamSchedule>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<long> BatchCounter { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblAssignment> tblAssignments { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblBatchAdmission> tblBatchAdmissions { get; set; }
        public virtual ICollection<tblBatchAdmission> tblBatchAdmissions1 { get; set; }
        public virtual ICollection<tblBatchAdmissionArchive> tblBatchAdmissionArchives { get; set; }
        public virtual ICollection<tblBatchAdmissionArchive> tblBatchAdmissionArchives1 { get; set; }
        public virtual ICollection<tblBatchAdmissionPast> tblBatchAdmissionPasts { get; set; }
        public virtual ICollection<tblCourseFeeDetail> tblCourseFeeDetails { get; set; }
        public virtual ICollection<tblExamSchedule> tblExamSchedules { get; set; }
    }
}
