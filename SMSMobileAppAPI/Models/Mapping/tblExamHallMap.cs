using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblExamHallMap : EntityTypeConfiguration<tblExamHall>
    {
        public tblExamHallMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblExamHall");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HallNumber).HasColumnName("HallNumber");
            this.Property(t => t.SeatingCapacity).HasColumnName("SeatingCapacity");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblExamHalls)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
