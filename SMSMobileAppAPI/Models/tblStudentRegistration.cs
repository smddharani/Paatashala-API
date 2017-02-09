using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStudentRegistration
    {
        public long Id { get; set; }
        public Nullable<long> StudentId { get; set; }
        public Nullable<long> RegistrationNo { get; set; }
        public string RegistrationCode { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public Nullable<long> RegistrationStatus { get; set; }
        public string LeadNumber { get; set; }
        public Nullable<long> Stream { get; set; }
        public Nullable<long> Course { get; set; }
        public Nullable<long> Batch { get; set; }
        public string Section { get; set; }
        public Nullable<long> AdmissionStatus { get; set; }
        public Nullable<long> CostCenter { get; set; }
        public Nullable<bool> HasPhoto { get; set; }
        public Nullable<bool> HasAdmissionLetter { get; set; }
        public Nullable<bool> HasInterviewDocuments { get; set; }
        public Nullable<bool> HasBirthCertificate { get; set; }
        public Nullable<bool> HasLeavingCertificate { get; set; }
        public Nullable<bool> HasMedicalCertificate { get; set; }
        public Nullable<bool> HasIncomeCertificate { get; set; }
        public Nullable<bool> HasCasteCertificate { get; set; }
        public long OrgId { get; set; }
        public virtual tblAdmissionStatusType tblAdmissionStatusType { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}
