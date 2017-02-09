using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblCourse
    {
        public tblCourse()
        {
            this.tblAssignments = new List<tblAssignment>();
            this.tblBatchAdmissions = new List<tblBatchAdmission>();
            this.tblBatchAdmissionArchives = new List<tblBatchAdmissionArchive>();
            this.tblBatchAdmissionPasts = new List<tblBatchAdmissionPast>();
            this.tblCourse_Subject = new List<tblCourse_Subject>();
            this.tblCourseFeeDetails = new List<tblCourseFeeDetail>();
            this.tblDietPlanDetails = new List<tblDietPlanDetail>();
            this.tblExamSchedules = new List<tblExamSchedule>();
            this.tblFeeInstallmentDetails = new List<tblFeeInstallmentDetail>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CourseCode { get; set; }
        public long StreamId { get; set; }
        public decimal Fees { get; set; }
        public int StudentInTake { get; set; }
        public long Sections { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> HasMultipleInstallments { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblAssignment> tblAssignments { get; set; }
        public virtual ICollection<tblBatchAdmission> tblBatchAdmissions { get; set; }
        public virtual ICollection<tblBatchAdmissionArchive> tblBatchAdmissionArchives { get; set; }
        public virtual ICollection<tblBatchAdmissionPast> tblBatchAdmissionPasts { get; set; }
        public virtual ICollection<tblCourse_Subject> tblCourse_Subject { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStream tblStream { get; set; }
        public virtual ICollection<tblCourseFeeDetail> tblCourseFeeDetails { get; set; }
        public virtual ICollection<tblDietPlanDetail> tblDietPlanDetails { get; set; }
        public virtual ICollection<tblExamSchedule> tblExamSchedules { get; set; }
        public virtual ICollection<tblFeeInstallmentDetail> tblFeeInstallmentDetails { get; set; }
    }
}
