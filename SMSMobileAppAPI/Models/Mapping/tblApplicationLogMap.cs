using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblApplicationLogMap : EntityTypeConfiguration<tblApplicationLog>
    {
        public tblApplicationLogMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ActionName)
                .HasMaxLength(500);

            this.Property(t => t.ControllerName)
                .HasMaxLength(500);

            this.Property(t => t.UserType)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblApplicationLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
            this.Property(t => t.ControllerName).HasColumnName("ControllerName");
            this.Property(t => t.RouteData).HasColumnName("RouteData");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");
        }
    }
}
