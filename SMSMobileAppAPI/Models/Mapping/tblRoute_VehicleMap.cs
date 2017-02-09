using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblRoute_VehicleMap : EntityTypeConfiguration<tblRoute_Vehicle>
    {
        public tblRoute_VehicleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblRoute$Vehicle");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RouteId).HasColumnName("RouteId");
            this.Property(t => t.VehicleId).HasColumnName("VehicleId");
            this.Property(t => t.DriverId).HasColumnName("DriverId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblDriver)
                .WithMany(t => t.tblRoute_Vehicle)
                .HasForeignKey(d => d.DriverId);
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblRoute_Vehicle)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblRoute)
                .WithMany(t => t.tblRoute_Vehicle)
                .HasForeignKey(d => d.RouteId);
            this.HasOptional(t => t.tblVehicle)
                .WithMany(t => t.tblRoute_Vehicle)
                .HasForeignKey(d => d.VehicleId);

        }
    }
}
