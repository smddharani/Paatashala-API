using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAssignmentMap : EntityTypeConfiguration<tblAssignment>
    {
        public tblAssignmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AssignmentName)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblAssignment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.BatchId).HasColumnName("BatchId");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.AssignmentName).HasColumnName("AssignmentName");
            this.Property(t => t.DateOfAssignment).HasColumnName("DateOfAssignment");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblBatch)
                .WithMany(t => t.tblAssignments)
                .HasForeignKey(d => d.BatchId);
            this.HasRequired(t => t.tblCourse)
                .WithMany(t => t.tblAssignments)
                .HasForeignKey(d => d.CourseId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblAssignments)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblSubject)
                .WithMany(t => t.tblAssignments)
                .HasForeignKey(d => d.SubjectId);

        }
    }
}
