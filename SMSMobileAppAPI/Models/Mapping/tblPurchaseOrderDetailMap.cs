using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblPurchaseOrderDetailMap : EntityTypeConfiguration<tblPurchaseOrderDetail>
    {
        public tblPurchaseOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblPurchaseOrderDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HeaderId).HasColumnName("HeaderId");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.PricePerUnit).HasColumnName("PricePerUnit");
            this.Property(t => t.DiscountPercent).HasColumnName("DiscountPercent");
            this.Property(t => t.TaxPercent).HasColumnName("TaxPercent");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblPurchaseOrderDetails)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblPurchaseOrderHeader)
                .WithMany(t => t.tblPurchaseOrderDetails)
                .HasForeignKey(d => d.HeaderId);
            this.HasOptional(t => t.tblStockGroup)
                .WithMany(t => t.tblPurchaseOrderDetails)
                .HasForeignKey(d => d.ItemCode);
            this.HasOptional(t => t.tblStockItem)
                .WithMany(t => t.tblPurchaseOrderDetails)
                .HasForeignKey(d => d.Item);

        }
    }
}
