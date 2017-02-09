using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblFeeItemDetailMap : EntityTypeConfiguration<tblFeeItemDetail>
    {
        public tblFeeItemDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            this.Property(t => t.UOM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblFeeItemDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.LedgerGroup).HasColumnName("LedgerGroup");
            this.Property(t => t.UOM).HasColumnName("UOM");
            this.Property(t => t.RatePerUnit).HasColumnName("RatePerUnit");
            this.Property(t => t.BillingType).HasColumnName("BillingType");
            this.Property(t => t.StandardRate).HasColumnName("StandardRate");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblFeeLedgerGroup)
                .WithMany(t => t.tblFeeItemDetails)
                .HasForeignKey(d => d.LedgerGroup);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblFeeItemDetails)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
