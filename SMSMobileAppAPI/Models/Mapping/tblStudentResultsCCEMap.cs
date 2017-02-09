using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentResultsCCEMap : EntityTypeConfiguration<tblStudentResultsCCE>
    {
        public tblStudentResultsCCEMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblStudentResultsCCE");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.TermId).HasColumnName("TermId");
            this.Property(t => t.FAId).HasColumnName("FAId");
            this.Property(t => t.BlockId).HasColumnName("BlockId");
            this.Property(t => t.SubBlockId).HasColumnName("SubBlockId");
            this.Property(t => t.LearnoMeterId).HasColumnName("LearnoMeterId");
            this.Property(t => t.SAId).HasColumnName("SAId");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.BatchId).HasColumnName("BatchId");
            this.Property(t => t.ExamId).HasColumnName("ExamId");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudentResultsCCEs)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
