using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentAttachmentMap : EntityTypeConfiguration<tblStudentAttachment>
    {
        public tblStudentAttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FileName)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("tblStudentAttachment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileSizeInBytes).HasColumnName("FileSizeInBytes");
            this.Property(t => t.Attachment).HasColumnName("Attachment");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudentAttachments)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStudent)
                .WithMany(t => t.tblStudentAttachments)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
