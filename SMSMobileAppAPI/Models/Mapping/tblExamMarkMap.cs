using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblExamMarkMap : EntityTypeConfiguration<tblExamMark>
    {
        public tblExamMarkMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblExamMarks");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ExamSchdeduleId).HasColumnName("ExamSchdeduleId");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.Marks).HasColumnName("Marks");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblExamSchedule)
                .WithMany(t => t.tblExamMarks)
                .HasForeignKey(d => d.ExamSchdeduleId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblExamMarks)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStudent)
                .WithMany(t => t.tblExamMarks)
                .HasForeignKey(d => d.StudentId);
            this.HasRequired(t => t.tblSubject)
                .WithMany(t => t.tblExamMarks)
                .HasForeignKey(d => d.SubjectId);

        }
    }
}
