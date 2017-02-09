using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblMessageAttachmentMap : EntityTypeConfiguration<tblMessageAttachment>
    {
        public tblMessageAttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblMessageAttachments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FromId).HasColumnName("FromId");
            this.Property(t => t.Attachments).HasColumnName("Attachments");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblMessageCenter)
                .WithMany(t => t.tblMessageAttachments)
                .HasForeignKey(d => d.FromId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblMessageAttachments)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
