using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblCourse_SubjectMap : EntityTypeConfiguration<tblCourse_Subject>
    {
        public tblCourse_SubjectMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblCourse$Subject");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblCourse)
                .WithMany(t => t.tblCourse_Subject)
                .HasForeignKey(d => d.CourseId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblCourse_Subject)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblSubject)
                .WithMany(t => t.tblCourse_Subject)
                .HasForeignKey(d => d.SubjectId);

        }
    }
}
