using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentRegistrationMap : EntityTypeConfiguration<tblStudentRegistration>
    {
        public tblStudentRegistrationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.RegistrationCode)
                .HasMaxLength(50);

            this.Property(t => t.LeadNumber)
                .HasMaxLength(100);

            this.Property(t => t.Section)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("tblStudentRegistration");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.RegistrationNo).HasColumnName("RegistrationNo");
            this.Property(t => t.RegistrationCode).HasColumnName("RegistrationCode");
            this.Property(t => t.RegistrationDate).HasColumnName("RegistrationDate");
            this.Property(t => t.RegistrationStatus).HasColumnName("RegistrationStatus");
            this.Property(t => t.LeadNumber).HasColumnName("LeadNumber");
            this.Property(t => t.Stream).HasColumnName("Stream");
            this.Property(t => t.Course).HasColumnName("Course");
            this.Property(t => t.Batch).HasColumnName("Batch");
            this.Property(t => t.Section).HasColumnName("Section");
            this.Property(t => t.AdmissionStatus).HasColumnName("AdmissionStatus");
            this.Property(t => t.CostCenter).HasColumnName("CostCenter");
            this.Property(t => t.HasPhoto).HasColumnName("HasPhoto");
            this.Property(t => t.HasAdmissionLetter).HasColumnName("HasAdmissionLetter");
            this.Property(t => t.HasInterviewDocuments).HasColumnName("HasInterviewDocuments");
            this.Property(t => t.HasBirthCertificate).HasColumnName("HasBirthCertificate");
            this.Property(t => t.HasLeavingCertificate).HasColumnName("HasLeavingCertificate");
            this.Property(t => t.HasMedicalCertificate).HasColumnName("HasMedicalCertificate");
            this.Property(t => t.HasIncomeCertificate).HasColumnName("HasIncomeCertificate");
            this.Property(t => t.HasCasteCertificate).HasColumnName("HasCasteCertificate");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblAdmissionStatusType)
                .WithMany(t => t.tblStudentRegistrations)
                .HasForeignKey(d => d.AdmissionStatus);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudentRegistrations)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblStudent)
                .WithMany(t => t.tblStudentRegistrations)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
