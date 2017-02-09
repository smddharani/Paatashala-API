using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblDriverMap : EntityTypeConfiguration<tblDriver>
    {
        public tblDriverMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblDriver");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PresentAddress).HasColumnName("PresentAddress");
            this.Property(t => t.PermanentAddress).HasColumnName("PermanentAddress");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.LicenseNumber).HasColumnName("LicenseNumber");
            this.Property(t => t.LicenseExpiry).HasColumnName("LicenseExpiry");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblDrivers)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
