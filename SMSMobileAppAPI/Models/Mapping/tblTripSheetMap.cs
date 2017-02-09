using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTripSheetMap : EntityTypeConfiguration<tblTripSheet>
    {
        public tblTripSheetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblTripSheet");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RouteVehicleId).HasColumnName("RouteVehicleId");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTripSheets)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblRoute_Vehicle)
                .WithMany(t => t.tblTripSheets)
                .HasForeignKey(d => d.RouteVehicleId);

        }
    }
}
