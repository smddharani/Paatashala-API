using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblPurchaseOrderHeaderMap : EntityTypeConfiguration<tblPurchaseOrderHeader>
    {
        public tblPurchaseOrderHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PONumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblPurchaseOrderHeader");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.TaxTypeId).HasColumnName("TaxTypeId");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.VendorAddress).HasColumnName("VendorAddress");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.PONumber).HasColumnName("PONumber");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblPurchaseOrderHeaders)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblVendor)
                .WithMany(t => t.tblPurchaseOrderHeaders)
                .HasForeignKey(d => d.VendorId);

        }
    }
}
