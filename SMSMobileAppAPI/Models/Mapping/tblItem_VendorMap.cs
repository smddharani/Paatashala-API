using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblItem_VendorMap : EntityTypeConfiguration<tblItem_Vendor>
    {
        public tblItem_VendorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblItem$Vendor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblItem)
                .WithMany(t => t.tblItem_Vendor)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblItem_Vendor)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblVendor)
                .WithMany(t => t.tblItem_Vendor)
                .HasForeignKey(d => d.VendorId);

        }
    }
}
