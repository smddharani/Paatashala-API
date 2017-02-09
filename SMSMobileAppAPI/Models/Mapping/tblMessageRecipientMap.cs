using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblMessageRecipientMap : EntityTypeConfiguration<tblMessageRecipient>
    {
        public tblMessageRecipientMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblMessageRecipients");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FromId).HasColumnName("FromId");
            this.Property(t => t.ToId).HasColumnName("ToId");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblEmployee)
                .WithMany(t => t.tblMessageRecipients)
                .HasForeignKey(d => d.ToId);
            this.HasRequired(t => t.tblMessageCenter)
                .WithMany(t => t.tblMessageRecipients)
                .HasForeignKey(d => d.FromId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblMessageRecipients)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
