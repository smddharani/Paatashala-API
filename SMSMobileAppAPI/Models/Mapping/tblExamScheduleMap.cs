using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblExamScheduleMap : EntityTypeConfiguration<tblExamSchedule>
    {
        public tblExamScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblExamSchedule");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ExamType).HasColumnName("ExamType");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.BatchId).HasColumnName("BatchId");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.Duration).HasColumnName("Duration");
            this.Property(t => t.Faculty).HasColumnName("Faculty");
            this.Property(t => t.ExamHall).HasColumnName("ExamHall");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblBatch)
                .WithMany(t => t.tblExamSchedules)
                .HasForeignKey(d => d.BatchId);
            this.HasOptional(t => t.tblCourse)
                .WithMany(t => t.tblExamSchedules)
                .HasForeignKey(d => d.CourseId);
            this.HasOptional(t => t.tblEmployee)
                .WithMany(t => t.tblExamSchedules)
                .HasForeignKey(d => d.Faculty);
            this.HasOptional(t => t.tblExamHall)
                .WithMany(t => t.tblExamSchedules)
                .HasForeignKey(d => d.ExamHall);
            this.HasOptional(t => t.tblExamType)
                .WithMany(t => t.tblExamSchedules)
                .HasForeignKey(d => d.ExamType);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblExamSchedules)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblSubject)
                .WithMany(t => t.tblExamSchedules)
                .HasForeignKey(d => d.SubjectId);

        }
    }
}
