using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblGPSDataMap : EntityTypeConfiguration<tblGPSData>
    {
        public tblGPSDataMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblGPSData");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RouteCode).HasColumnName("RouteCode");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblGPSDatas)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblRoute)
                .WithMany(t => t.tblGPSDatas)
                .HasForeignKey(d => d.RouteCode);

        }
    }
}
