using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblOrgMap : EntityTypeConfiguration<tblOrg>
    {
        public tblOrgMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.OrgName)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.OrgFullName)
                .HasMaxLength(500);

            this.Property(t => t.PrimaryContact)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(500);

            this.Property(t => t.AddressLine1)
                .HasMaxLength(500);

            this.Property(t => t.AddressLine2)
                .HasMaxLength(500);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.Zip)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblOrg");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrgName).HasColumnName("OrgName");
            this.Property(t => t.OrgFullName).HasColumnName("OrgFullName");
            this.Property(t => t.PrimaryContact).HasColumnName("PrimaryContact");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.SubscriptionStartDate).HasColumnName("SubscriptionStartDate");
            this.Property(t => t.SubscriptionEndDate).HasColumnName("SubscriptionEndDate");
            this.Property(t => t.OrgPhoto).HasColumnName("OrgPhoto");
        }
    }
}
