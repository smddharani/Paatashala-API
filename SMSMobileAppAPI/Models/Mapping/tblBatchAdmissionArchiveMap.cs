using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblBatchAdmissionArchiveMap : EntityTypeConfiguration<tblBatchAdmissionArchive>
    {
        public tblBatchAdmissionArchiveMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Section)
                .HasMaxLength(1);

            this.Property(t => t.RollNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblBatchAdmissionArchive");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.BatchId).HasColumnName("BatchId");
            this.Property(t => t.PrevBatchId).HasColumnName("PrevBatchId");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.Section).HasColumnName("Section");
            this.Property(t => t.RollNumber).HasColumnName("RollNumber");
            this.Property(t => t.AdmissionStatus).HasColumnName("AdmissionStatus");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblBatch)
                .WithMany(t => t.tblBatchAdmissionArchives)
                .HasForeignKey(d => d.BatchId);
            this.HasOptional(t => t.tblBatch1)
                .WithMany(t => t.tblBatchAdmissionArchives1)
                .HasForeignKey(d => d.PrevBatchId);
            this.HasRequired(t => t.tblCourse)
                .WithMany(t => t.tblBatchAdmissionArchives)
                .HasForeignKey(d => d.CourseId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblBatchAdmissionArchives)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStudent)
                .WithMany(t => t.tblBatchAdmissionArchives)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
