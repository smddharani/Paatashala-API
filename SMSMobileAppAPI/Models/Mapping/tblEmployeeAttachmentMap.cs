using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblEmployeeAttachmentMap : EntityTypeConfiguration<tblEmployeeAttachment>
    {
        public tblEmployeeAttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FileName)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("tblEmployeeAttachment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.Attachment).HasColumnName("Attachment");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileSizeInBytes).HasColumnName("FileSizeInBytes");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblEmployee)
                .WithMany(t => t.tblEmployeeAttachments)
                .HasForeignKey(d => d.EmployeeId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblEmployeeAttachments)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
