using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStockGroupMap : EntityTypeConfiguration<tblStockGroup>
    {
        public tblStockGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.GroupName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblStockGroup");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStockGroups)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
