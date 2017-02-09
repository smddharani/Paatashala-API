using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentCustomizeValueMap : EntityTypeConfiguration<tblStudentCustomizeValue>
    {
        public tblStudentCustomizeValueMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblStudentCustomizeValues");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FieldId).HasColumnName("FieldId");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudentCustomizeValues)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
