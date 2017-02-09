using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblCourseMap : EntityTypeConfiguration<tblCourse>
    {
        public tblCourseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            this.Property(t => t.CourseCode)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("tblCourse");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CourseCode).HasColumnName("CourseCode");
            this.Property(t => t.StreamId).HasColumnName("StreamId");
            this.Property(t => t.Fees).HasColumnName("Fees");
            this.Property(t => t.StudentInTake).HasColumnName("StudentInTake");
            this.Property(t => t.Sections).HasColumnName("Sections");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.HasMultipleInstallments).HasColumnName("HasMultipleInstallments");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblCourses)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStream)
                .WithMany(t => t.tblCourses)
                .HasForeignKey(d => d.StreamId);

        }
    }
}
