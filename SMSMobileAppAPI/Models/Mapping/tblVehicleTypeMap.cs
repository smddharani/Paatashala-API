using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblVehicleTypeMap : EntityTypeConfiguration<tblVehicleType>
    {
        public tblVehicleTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblVehicleType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblVehicleTypes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
