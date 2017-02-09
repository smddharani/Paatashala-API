using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblInstitutionMap : EntityTypeConfiguration<tblInstitution>
    {
        public tblInstitutionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblInstitution");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.AdminContact).HasColumnName("AdminContact");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.CurrencyType).HasColumnName("CurrencyType");
            this.Property(t => t.InstittuionCode).HasColumnName("InstittuionCode");
            this.Property(t => t.TimeZone).HasColumnName("TimeZone");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblInstitutions)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
