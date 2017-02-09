using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblBlockAttributesCCEMap : EntityTypeConfiguration<tblBlockAttributesCCE>
    {
        public tblBlockAttributesCCEMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AttributeName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblBlockAttributesCCE");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AttributeValue).HasColumnName("AttributeValue");
            this.Property(t => t.AttributeName).HasColumnName("AttributeName");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblBlockAttributesCCEs)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
