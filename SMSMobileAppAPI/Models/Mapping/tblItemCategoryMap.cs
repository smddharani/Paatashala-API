using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblItemCategoryMap : EntityTypeConfiguration<tblItemCategory>
    {
        public tblItemCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblItemCategory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblItemCategories)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
