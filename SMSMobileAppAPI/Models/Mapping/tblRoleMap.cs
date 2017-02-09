using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblRoleMap : EntityTypeConfiguration<tblRole>
    {
        public tblRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.RoleName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblRole");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblRoles)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
