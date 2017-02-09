using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblRouteStopMap : EntityTypeConfiguration<tblRouteStop>
    {
        public tblRouteStopMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblRouteStops");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StopName).HasColumnName("StopName");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblRouteStops)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
