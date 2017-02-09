using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentCustomizeMap : EntityTypeConfiguration<tblStudentCustomize>
    {
        public tblStudentCustomizeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FieldName)
                .HasMaxLength(500);

            this.Property(t => t.FieldType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblStudentCustomize");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FieldName).HasColumnName("FieldName");
            this.Property(t => t.FieldType).HasColumnName("FieldType");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudentCustomizes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
