using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblHostel_RoomMap : EntityTypeConfiguration<tblHostel_Room>
    {
        public tblHostel_RoomMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblHostel$Room");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HostelId).HasColumnName("HostelId");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblHostel)
                .WithMany(t => t.tblHostel_Room)
                .HasForeignKey(d => d.HostelId);
            this.HasOptional(t => t.tblHostelRoom)
                .WithMany(t => t.tblHostel_Room)
                .HasForeignKey(d => d.RoomId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblHostel_Room)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
