using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblEmployeeMap : EntityTypeConfiguration<tblEmployee>
    {
        public tblEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.GuardianRelation)
                .HasMaxLength(50);

            this.Property(t => t.GuardianName)
                .HasMaxLength(50);

            this.Property(t => t.PlaceOfBirth)
                .HasMaxLength(50);

            this.Property(t => t.StateOfDomicile)
                .HasMaxLength(50);

            this.Property(t => t.RhType)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.PassportNo)
                .HasMaxLength(50);

            this.Property(t => t.NomineeName)
                .HasMaxLength(50);

            this.Property(t => t.NomineeRelation)
                .HasMaxLength(50);

            this.Property(t => t.MotherTongue)
                .HasMaxLength(50);

            this.Property(t => t.LanguagesKnown)
                .HasMaxLength(50);

            this.Property(t => t.IdentificationMarks)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblEmployee");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DepartmentId).HasColumnName("DepartmentId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.GuardianRelation).HasColumnName("GuardianRelation");
            this.Property(t => t.GuardianName).HasColumnName("GuardianName");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.DateOfJoining).HasColumnName("DateOfJoining");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.PlaceOfBirth).HasColumnName("PlaceOfBirth");
            this.Property(t => t.Religion).HasColumnName("Religion");
            this.Property(t => t.Nationality).HasColumnName("Nationality");
            this.Property(t => t.SpouseName).HasColumnName("SpouseName");
            this.Property(t => t.SpouseNationalId).HasColumnName("SpouseNationalId");
            this.Property(t => t.StateOfDomicile).HasColumnName("StateOfDomicile");
            this.Property(t => t.EmpStatus).HasColumnName("EmpStatus");
            this.Property(t => t.Experience).HasColumnName("Experience");
            this.Property(t => t.NoOfDepedents).HasColumnName("NoOfDepedents");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.RhType).HasColumnName("RhType");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.PassportNo).HasColumnName("PassportNo");
            this.Property(t => t.PanNo).HasColumnName("PanNo");
            this.Property(t => t.NomineeName).HasColumnName("NomineeName");
            this.Property(t => t.NomineeRelation).HasColumnName("NomineeRelation");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.MotherTongue).HasColumnName("MotherTongue");
            this.Property(t => t.LanguagesKnown).HasColumnName("LanguagesKnown");
            this.Property(t => t.IdentificationMarks).HasColumnName("IdentificationMarks");
            this.Property(t => t.PresentAddressLine1).HasColumnName("PresentAddressLine1");
            this.Property(t => t.PresentAddressLine2).HasColumnName("PresentAddressLine2");
            this.Property(t => t.PresentCountry).HasColumnName("PresentCountry");
            this.Property(t => t.PresentState).HasColumnName("PresentState");
            this.Property(t => t.PresentCity).HasColumnName("PresentCity");
            this.Property(t => t.PresentArea).HasColumnName("PresentArea");
            this.Property(t => t.PermanentAddresLine1).HasColumnName("PermanentAddresLine1");
            this.Property(t => t.PermanentAddressLine2).HasColumnName("PermanentAddressLine2");
            this.Property(t => t.PermanentCountry).HasColumnName("PermanentCountry");
            this.Property(t => t.PermanentState).HasColumnName("PermanentState");
            this.Property(t => t.PermanentCity).HasColumnName("PermanentCity");
            this.Property(t => t.PermanentArea).HasColumnName("PermanentArea");
            this.Property(t => t.HasLoginAccess).HasColumnName("HasLoginAccess");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblDepartment)
                .WithMany(t => t.tblEmployees)
                .HasForeignKey(d => d.DepartmentId);
            this.HasOptional(t => t.tblDesignation)
                .WithMany(t => t.tblEmployees)
                .HasForeignKey(d => d.Designation);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblEmployees)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblRole)
                .WithMany(t => t.tblEmployees)
                .HasForeignKey(d => d.RoleId);

        }
    }
}
