using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTaxDetailMap : EntityTypeConfiguration<tblTaxDetail>
    {
        public tblTaxDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblTaxDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.TaxTypeId).HasColumnName("TaxTypeId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTaxDetails)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblTaxType)
                .WithMany(t => t.tblTaxDetails)
                .HasForeignKey(d => d.TaxTypeId);

        }
    }
}
