using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblEmployee
    {
        public tblEmployee()
        {
            this.tblEmployeeAdditionalInfoes = new List<tblEmployeeAdditionalInfo>();
            this.tblEmployeeAttachments = new List<tblEmployeeAttachment>();
            this.tblEmpSalaryDetails = new List<tblEmpSalaryDetail>();
            this.tblExamSchedules = new List<tblExamSchedule>();
            this.tblImageGalleries = new List<tblImageGallery>();
            this.tblLeadFollowUps = new List<tblLeadFollowUp>();
            this.tblLeadFollowUps1 = new List<tblLeadFollowUp>();
            this.tblMessageCenters = new List<tblMessageCenter>();
            this.tblMessageRecipients = new List<tblMessageRecipient>();
            this.tblPayrolls = new List<tblPayroll>();
        }

        public long Id { get; set; }
        public Nullable<long> DepartmentId { get; set; }
        public Nullable<long> RoleId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<long> EmpId { get; set; }
        public Nullable<long> Sex { get; set; }
        public string GuardianRelation { get; set; }
        public string GuardianName { get; set; }
        public Nullable<long> MaritalStatus { get; set; }
        public Nullable<System.DateTime> DateOfJoining { get; set; }
        public Nullable<long> Designation { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<long> Age { get; set; }
        public string PlaceOfBirth { get; set; }
        public Nullable<long> Religion { get; set; }
        public Nullable<long> Nationality { get; set; }
        public string SpouseName { get; set; }
        public Nullable<long> SpouseNationalId { get; set; }
        public string StateOfDomicile { get; set; }
        public Nullable<long> EmpStatus { get; set; }
        public Nullable<long> Experience { get; set; }
        public Nullable<long> NoOfDepedents { get; set; }
        public Nullable<long> Height { get; set; }
        public Nullable<long> Weight { get; set; }
        public Nullable<long> BloodGroup { get; set; }
        public string RhType { get; set; }
        public Nullable<long> Phone { get; set; }
        public string Email { get; set; }
        public string PassportNo { get; set; }
        public Nullable<long> PanNo { get; set; }
        public string NomineeName { get; set; }
        public string NomineeRelation { get; set; }
        public byte[] Photo { get; set; }
        public string MotherTongue { get; set; }
        public string LanguagesKnown { get; set; }
        public string IdentificationMarks { get; set; }
        public string PresentAddressLine1 { get; set; }
        public string PresentAddressLine2 { get; set; }
        public string PresentCountry { get; set; }
        public string PresentState { get; set; }
        public string PresentCity { get; set; }
        public string PresentArea { get; set; }
        public string PermanentAddresLine1 { get; set; }
        public string PermanentAddressLine2 { get; set; }
        public string PermanentCountry { get; set; }
        public string PermanentState { get; set; }
        public string PermanentCity { get; set; }
        public string PermanentArea { get; set; }
        public Nullable<bool> HasLoginAccess { get; set; }
        public long OrgId { get; set; }
        public virtual tblDepartment tblDepartment { get; set; }
        public virtual tblDesignation tblDesignation { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblRole tblRole { get; set; }
        public virtual ICollection<tblEmployeeAdditionalInfo> tblEmployeeAdditionalInfoes { get; set; }
        public virtual ICollection<tblEmployeeAttachment> tblEmployeeAttachments { get; set; }
        public virtual ICollection<tblEmpSalaryDetail> tblEmpSalaryDetails { get; set; }
        public virtual ICollection<tblExamSchedule> tblExamSchedules { get; set; }
        public virtual ICollection<tblImageGallery> tblImageGalleries { get; set; }
        public virtual ICollection<tblLeadFollowUp> tblLeadFollowUps { get; set; }
        public virtual ICollection<tblLeadFollowUp> tblLeadFollowUps1 { get; set; }
        public virtual ICollection<tblMessageCenter> tblMessageCenters { get; set; }
        public virtual ICollection<tblMessageRecipient> tblMessageRecipients { get; set; }
        public virtual ICollection<tblPayroll> tblPayrolls { get; set; }
    }
}
