using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTaxTypeMap : EntityTypeConfiguration<tblTaxType>
    {
        public tblTaxTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblTaxType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TaxPercent).HasColumnName("TaxPercent");
            this.Property(t => t.TaxAtSource).HasColumnName("TaxAtSource");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTaxTypes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
