using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblMessageCenterMap : EntityTypeConfiguration<tblMessageCenter>
    {
        public tblMessageCenterMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MessageTitle)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblMessageCenter");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.MessageBody).HasColumnName("MessageBody");
            this.Property(t => t.MessageTitle).HasColumnName("MessageTitle");
            this.Property(t => t.SentDate).HasColumnName("SentDate");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblEmployee)
                .WithMany(t => t.tblMessageCenters)
                .HasForeignKey(d => d.EmpId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblMessageCenters)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
