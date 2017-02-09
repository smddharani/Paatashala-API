using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudent
    {
        public tblStudent()
        {
            this.CounsellorNotes = new List<CounsellorNote>();
            this.tblAttendances = new List<tblAttendance>();
            this.tblAttendanceHourlies = new List<tblAttendanceHourly>();
            this.tblBatchAdmissions = new List<tblBatchAdmission>();
            this.tblBatchAdmissionArchives = new List<tblBatchAdmissionArchive>();
            this.tblBatchAdmissionPasts = new List<tblBatchAdmissionPast>();
            this.tblExamMarks = new List<tblExamMark>();
            this.tblLeadFollowUps = new List<tblLeadFollowUp>();
            this.tblStudentAttachments = new List<tblStudentAttachment>();
            this.tblStudentFeePaidHeaders = new List<tblStudentFeePaidHeader>();
            this.tblStudentQualifications = new List<tblStudentQualification>();
            this.tblStudentRegistrations = new List<tblStudentRegistration>();
            this.tblStudentValues = new List<tblStudentValue>();
            this.tblTransportTripSheets = new List<tblTransportTripSheet>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<long> StudentId { get; set; }
        public string FatherName { get; set; }
        public string FatherEmail { get; set; }
        public Nullable<System.DateTime> FatherDOB { get; set; }
        public string MotherName { get; set; }
        public string MotherEmail { get; set; }
        public Nullable<System.DateTime> MotherDOB { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> ParentsAnniversary { get; set; }
        public string Sex { get; set; }
        public Nullable<bool> MaritalStatus { get; set; }
        public Nullable<long> Religion { get; set; }
        public Nullable<long> Category { get; set; }
        public Nullable<long> Natiionality { get; set; }
        public Nullable<long> State { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string ContactNo { get; set; }
        public Nullable<int> MobileNo { get; set; }
        public string Email { get; set; }
        public Nullable<bool> IsPhysicallyChallenged { get; set; }
        public Nullable<long> MediumOfInstruction { get; set; }
        public Nullable<decimal> FatherIncome { get; set; }
        public string PassportNo { get; set; }
        public Nullable<long> NationalId { get; set; }
        public Nullable<bool> IsTransportRequired { get; set; }
        public Nullable<bool> IsHostelRequired { get; set; }
        public Nullable<long> BloodGroup { get; set; }
        public Nullable<long> FinancialSupport { get; set; }
        public Nullable<bool> IsConvicted { get; set; }
        public string IsConvictedReason { get; set; }
        public Nullable<bool> IsPriorExpelled { get; set; }
        public string IsPriorExpelledReason { get; set; }
        public string EmergencyContactPerson { get; set; }
        public Nullable<long> EmergencyContactNo { get; set; }
        public string EmergencyContactRelation { get; set; }
        public byte[] Photo { get; set; }
        public string FatherQualification { get; set; }
        public string MotherQualification { get; set; }
        public Nullable<bool> TCIssued { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<long> DiscountType { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<bool> IsLead { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<CounsellorNote> CounsellorNotes { get; set; }
        public virtual ICollection<tblAttendance> tblAttendances { get; set; }
        public virtual ICollection<tblAttendanceHourly> tblAttendanceHourlies { get; set; }
        public virtual ICollection<tblBatchAdmission> tblBatchAdmissions { get; set; }
        public virtual ICollection<tblBatchAdmissionArchive> tblBatchAdmissionArchives { get; set; }
        public virtual ICollection<tblBatchAdmissionPast> tblBatchAdmissionPasts { get; set; }
        public virtual tblDiscountType tblDiscountType { get; set; }
        public virtual ICollection<tblExamMark> tblExamMarks { get; set; }
        public virtual ICollection<tblLeadFollowUp> tblLeadFollowUps { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudentCategory tblStudentCategory { get; set; }
        public virtual ICollection<tblStudentAttachment> tblStudentAttachments { get; set; }
        public virtual ICollection<tblStudentFeePaidHeader> tblStudentFeePaidHeaders { get; set; }
        public virtual ICollection<tblStudentQualification> tblStudentQualifications { get; set; }
        public virtual ICollection<tblStudentRegistration> tblStudentRegistrations { get; set; }
        public virtual ICollection<tblStudentValue> tblStudentValues { get; set; }
        public virtual ICollection<tblTransportTripSheet> tblTransportTripSheets { get; set; }
    }
}
