using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentMap : EntityTypeConfiguration<tblStudent>
    {
        public tblStudentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(50);

            this.Property(t => t.MiddleName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .HasMaxLength(50);

            this.Property(t => t.FatherName)
                .HasMaxLength(50);

            this.Property(t => t.FatherEmail)
                .HasMaxLength(500);

            this.Property(t => t.MotherName)
                .HasMaxLength(50);

            this.Property(t => t.MotherEmail)
                .HasMaxLength(500);

            this.Property(t => t.Sex)
                .HasMaxLength(50);

            this.Property(t => t.ContactNo)
                .HasMaxLength(50);

            this.Property(t => t.PassportNo)
                .HasMaxLength(50);

            this.Property(t => t.EmergencyContactPerson)
                .HasMaxLength(50);

            this.Property(t => t.EmergencyContactRelation)
                .HasMaxLength(50);

            this.Property(t => t.FatherQualification)
                .HasMaxLength(200);

            this.Property(t => t.MotherQualification)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblStudent");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.FatherName).HasColumnName("FatherName");
            this.Property(t => t.FatherEmail).HasColumnName("FatherEmail");
            this.Property(t => t.FatherDOB).HasColumnName("FatherDOB");
            this.Property(t => t.MotherName).HasColumnName("MotherName");
            this.Property(t => t.MotherEmail).HasColumnName("MotherEmail");
            this.Property(t => t.MotherDOB).HasColumnName("MotherDOB");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.ParentsAnniversary).HasColumnName("ParentsAnniversary");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.Religion).HasColumnName("Religion");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Natiionality).HasColumnName("Natiionality");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CurrentAddress).HasColumnName("CurrentAddress");
            this.Property(t => t.PermanentAddress).HasColumnName("PermanentAddress");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.MobileNo).HasColumnName("MobileNo");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.IsPhysicallyChallenged).HasColumnName("IsPhysicallyChallenged");
            this.Property(t => t.MediumOfInstruction).HasColumnName("MediumOfInstruction");
            this.Property(t => t.FatherIncome).HasColumnName("FatherIncome");
            this.Property(t => t.PassportNo).HasColumnName("PassportNo");
            this.Property(t => t.NationalId).HasColumnName("NationalId");
            this.Property(t => t.IsTransportRequired).HasColumnName("IsTransportRequired");
            this.Property(t => t.IsHostelRequired).HasColumnName("IsHostelRequired");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.FinancialSupport).HasColumnName("FinancialSupport");
            this.Property(t => t.IsConvicted).HasColumnName("IsConvicted");
            this.Property(t => t.IsConvictedReason).HasColumnName("IsConvictedReason");
            this.Property(t => t.IsPriorExpelled).HasColumnName("IsPriorExpelled");
            this.Property(t => t.IsPriorExpelledReason).HasColumnName("IsPriorExpelledReason");
            this.Property(t => t.EmergencyContactPerson).HasColumnName("EmergencyContactPerson");
            this.Property(t => t.EmergencyContactNo).HasColumnName("EmergencyContactNo");
            this.Property(t => t.EmergencyContactRelation).HasColumnName("EmergencyContactRelation");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.FatherQualification).HasColumnName("FatherQualification");
            this.Property(t => t.MotherQualification).HasColumnName("MotherQualification");
            this.Property(t => t.TCIssued).HasColumnName("TCIssued");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountType).HasColumnName("DiscountType");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.IsLead).HasColumnName("IsLead");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblDiscountType)
                .WithMany(t => t.tblStudents)
                .HasForeignKey(d => d.DiscountType);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudents)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblStudentCategory)
                .WithMany(t => t.tblStudents)
                .HasForeignKey(d => d.Category);

        }
    }
}
