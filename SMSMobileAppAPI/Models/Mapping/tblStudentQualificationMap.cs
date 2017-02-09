using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentQualificationMap : EntityTypeConfiguration<tblStudentQualification>
    {
        public tblStudentQualificationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblStudentQualifications");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.SchoolName).HasColumnName("SchoolName");
            this.Property(t => t.ClassOrCourse).HasColumnName("ClassOrCourse");
            this.Property(t => t.YearPassed).HasColumnName("YearPassed");
            this.Property(t => t.Percentage).HasColumnName("Percentage");
            this.Property(t => t.ReasonForExit).HasColumnName("ReasonForExit");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudentQualifications)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblStudent)
                .WithMany(t => t.tblStudentQualifications)
                .HasForeignKey(d => d.StudentId);
            this.HasRequired(t => t.tblStudentPrevQualificationReason)
                .WithMany(t => t.tblStudentQualifications)
                .HasForeignKey(d => d.ReasonForExit);

        }
    }
}
