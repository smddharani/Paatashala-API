using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblVisitorMap : EntityTypeConfiguration<tblVisitor>
    {
        public tblVisitorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblVisitors");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.VehicleNumber).HasColumnName("VehicleNumber");
            this.Property(t => t.ToMeet).HasColumnName("ToMeet");
            this.Property(t => t.PersonType).HasColumnName("PersonType");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.VechicleType).HasColumnName("VechicleType");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.OrgId).HasColumnName("OrgId");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblVisitors)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
