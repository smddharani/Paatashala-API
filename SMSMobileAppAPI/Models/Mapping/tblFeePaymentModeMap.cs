using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblFeePaymentModeMap : EntityTypeConfiguration<tblFeePaymentMode>
    {
        public tblFeePaymentModeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(500);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblFeePaymentMode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblFeePaymentModes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
