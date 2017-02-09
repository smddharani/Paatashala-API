using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAssetAttributeMap : EntityTypeConfiguration<tblAssetAttribute>
    {
        public tblAssetAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblAssetAttribute");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AssetId).HasColumnName("AssetId");
            this.Property(t => t.String).HasColumnName("String");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Decimal).HasColumnName("Decimal");
            this.Property(t => t.Integer).HasColumnName("Integer");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblAsset)
                .WithMany(t => t.tblAssetAttributes)
                .HasForeignKey(d => d.AssetId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblAssetAttributes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
