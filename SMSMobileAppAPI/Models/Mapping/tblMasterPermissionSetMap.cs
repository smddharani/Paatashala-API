using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblMasterPermissionSetMap : EntityTypeConfiguration<tblMasterPermissionSet>
    {
        public tblMasterPermissionSetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblMasterPermissionSet");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.ParentValue).HasColumnName("ParentValue");
        }
    }
}
