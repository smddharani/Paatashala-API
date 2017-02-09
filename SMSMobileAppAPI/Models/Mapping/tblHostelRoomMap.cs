using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblHostelRoomMap : EntityTypeConfiguration<tblHostelRoom>
    {
        public tblHostelRoomMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblHostelRoom");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RoomNumber).HasColumnName("RoomNumber");
            this.Property(t => t.RoomRent).HasColumnName("RoomRent");
            this.Property(t => t.Beds).HasColumnName("Beds");
            this.Property(t => t.TubeLights).HasColumnName("TubeLights");
            this.Property(t => t.Fan).HasColumnName("Fan");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblHostelRooms)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
