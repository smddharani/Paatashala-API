using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblItemMap : EntityTypeConfiguration<tblItem>
    {
        public tblItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Color)
                .HasMaxLength(50);

            this.Property(t => t.Size)
                .HasMaxLength(50);

            this.Property(t => t.Shape)
                .HasMaxLength(50);

            this.Property(t => t.Currency)
                .HasMaxLength(50);

            this.Property(t => t.Picture)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblItems");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.RebatePercentCP).HasColumnName("RebatePercentCP");
            this.Property(t => t.RebateOnCP).HasColumnName("RebateOnCP");
            this.Property(t => t.SPperUnit).HasColumnName("SPperUnit");
            this.Property(t => t.IsVatIncluded).HasColumnName("IsVatIncluded");
            this.Property(t => t.MRPperUnit).HasColumnName("MRPperUnit");
            this.Property(t => t.DiscountPercent).HasColumnName("DiscountPercent");
            this.Property(t => t.CSTpercent).HasColumnName("CSTpercent");
            this.Property(t => t.ItemStatus).HasColumnName("ItemStatus");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.MinQuantity).HasColumnName("MinQuantity");
            this.Property(t => t.MaxQuantity).HasColumnName("MaxQuantity");
            this.Property(t => t.DateOfPurchase).HasColumnName("DateOfPurchase");
            this.Property(t => t.Color).HasColumnName("Color");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.Shape).HasColumnName("Shape");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblItemCategory)
                .WithMany(t => t.tblItems)
                .HasForeignKey(d => d.CategoryId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblItems)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
