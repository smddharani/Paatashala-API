using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAssetMap : EntityTypeConfiguration<tblAsset>
    {
        public tblAssetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("tblAssets");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AssetCategory).HasColumnName("AssetCategory");
            this.Property(t => t.ParentAssetId).HasColumnName("ParentAssetId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblAssetCategory)
                .WithMany(t => t.tblAssets)
                .HasForeignKey(d => d.AssetCategory);
            this.HasOptional(t => t.tblAsset1)
                .WithMany(t => t.tblAssets1)
                .HasForeignKey(d => d.ParentAssetId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblAssets)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
