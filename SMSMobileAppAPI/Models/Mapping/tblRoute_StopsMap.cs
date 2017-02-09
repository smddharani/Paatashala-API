using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblRoute_StopsMap : EntityTypeConfiguration<tblRoute_Stops>
    {
        public tblRoute_StopsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblRoute$Stops");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RouteId).HasColumnName("RouteId");
            this.Property(t => t.StopId).HasColumnName("StopId");
            this.Property(t => t.RouteOrder).HasColumnName("RouteOrder");
            this.Property(t => t.ArrivalTime).HasColumnName("ArrivalTime");
            this.Property(t => t.DepartureTime).HasColumnName("DepartureTime");
            this.Property(t => t.IsRouteStart).HasColumnName("IsRouteStart");
            this.Property(t => t.IsRouteEnd).HasColumnName("IsRouteEnd");
            this.Property(t => t.DistanceFromStart).HasColumnName("DistanceFromStart");
            this.Property(t => t.DistanceToEnd).HasColumnName("DistanceToEnd");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblRoute_Stops)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblRoute)
                .WithMany(t => t.tblRoute_Stops)
                .HasForeignKey(d => d.RouteId);
            this.HasRequired(t => t.tblRouteStop)
                .WithMany(t => t.tblRoute_Stops)
                .HasForeignKey(d => d.StopId);

        }
    }
}
