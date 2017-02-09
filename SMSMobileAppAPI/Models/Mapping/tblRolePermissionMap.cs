using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblRolePermissionMap : EntityTypeConfiguration<tblRolePermission>
    {
        public tblRolePermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblRolePermission");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MasterPermissionValue).HasColumnName("MasterPermissionValue");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblRolePermissions)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblRole)
                .WithMany(t => t.tblRolePermissions)
                .HasForeignKey(d => d.RoleId);

        }
    }
}
