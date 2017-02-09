using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTransportTripSheetMap : EntityTypeConfiguration<tblTransportTripSheet>
    {
        public tblTransportTripSheetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblTransportTripSheet");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RouteId).HasColumnName("RouteId");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.PickTime).HasColumnName("PickTime");
            this.Property(t => t.DropTime).HasColumnName("DropTime");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTransportTripSheets)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblRoute)
                .WithMany(t => t.tblTransportTripSheets)
                .HasForeignKey(d => d.RouteId);
            this.HasRequired(t => t.tblStudent)
                .WithMany(t => t.tblTransportTripSheets)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
