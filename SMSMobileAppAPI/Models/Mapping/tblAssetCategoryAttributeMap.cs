using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAssetCategoryAttributeMap : EntityTypeConfiguration<tblAssetCategoryAttribute>
    {
        public tblAssetCategoryAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblAssetCategoryAttribute");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AttributeType).HasColumnName("AttributeType");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblAssetCategory)
                .WithMany(t => t.tblAssetCategoryAttributes)
                .HasForeignKey(d => d.CategoryId);
            this.HasRequired(t => t.tblAttributeType)
                .WithMany(t => t.tblAssetCategoryAttributes)
                .HasForeignKey(d => d.AttributeType);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblAssetCategoryAttributes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
