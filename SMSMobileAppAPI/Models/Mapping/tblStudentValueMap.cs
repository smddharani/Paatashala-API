using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentValueMap : EntityTypeConfiguration<tblStudentValue>
    {
        public tblStudentValueMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblStudentValues");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FieldId).HasColumnName("FieldId");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudentValues)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStudent)
                .WithMany(t => t.tblStudentValues)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
