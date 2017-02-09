using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblVisitorMaterialMap : EntityTypeConfiguration<tblVisitorMaterial>
    {
        public tblVisitorMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblVisitorMaterials");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MaterialName).HasColumnName("MaterialName");
            this.Property(t => t.VisitorId).HasColumnName("VisitorId");
            this.Property(t => t.IsRetuned).HasColumnName("IsRetuned");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblVisitorMaterials)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblVisitor)
                .WithMany(t => t.tblVisitorMaterials)
                .HasForeignKey(d => d.VisitorId);

        }
    }
}
