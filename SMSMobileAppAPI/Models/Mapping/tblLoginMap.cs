using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblLoginMap : EntityTypeConfiguration<tblLogin>
    {
        public tblLoginMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("tblLogin");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblLogins)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
