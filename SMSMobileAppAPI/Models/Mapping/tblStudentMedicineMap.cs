using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudentMedicineMap : EntityTypeConfiguration<tblStudentMedicine>
    {
        public tblStudentMedicineMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UOM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblStudentMedicine");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.AdministeredDate).HasColumnName("AdministeredDate");
            this.Property(t => t.MedicineId).HasColumnName("MedicineId");
            this.Property(t => t.UOM).HasColumnName("UOM");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblMedicineDetail)
                .WithMany(t => t.tblStudentMedicines)
                .HasForeignKey(d => d.MedicineId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblStudentMedicines)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
