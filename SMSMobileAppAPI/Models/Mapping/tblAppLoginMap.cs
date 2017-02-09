using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAppLoginMap : EntityTypeConfiguration<tblAppLogin>
    {
        public tblAppLoginMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Email)
                .HasMaxLength(500);

            this.Property(t => t.Password)
                .HasMaxLength(500);

            this.Property(t => t.Passcode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblAppLogin");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Passcode).HasColumnName("Passcode");
            this.Property(t => t.ValidTill).HasColumnName("ValidTill");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.IsRegistered).HasColumnName("IsRegistered");
        }
    }
}
