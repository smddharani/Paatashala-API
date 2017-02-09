using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblHostel_Room_StudentMap : EntityTypeConfiguration<tblHostel_Room_Student>
    {
        public tblHostel_Room_StudentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblHostel$Room$Student");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HostelRoomId).HasColumnName("HostelRoomId");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.PersonType).HasColumnName("PersonType");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.BillingType).HasColumnName("BillingType");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblHostel_Room)
                .WithMany(t => t.tblHostel_Room_Student)
                .HasForeignKey(d => d.HostelRoomId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblHostel_Room_Student)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
