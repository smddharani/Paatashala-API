using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblRouteMap : EntityTypeConfiguration<tblRoute>
    {
        public tblRouteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblRoute");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RouteCode).HasColumnName("RouteCode");
            this.Property(t => t.RouteStart).HasColumnName("RouteStart");
            this.Property(t => t.RouteEnd).HasColumnName("RouteEnd");
            this.Property(t => t.TotalDuration).HasColumnName("TotalDuration");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblRoutes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
