using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblPayrollMap : EntityTypeConfiguration<tblPayroll>
    {
        public tblPayrollMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblPayroll");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblEmployee)
                .WithMany(t => t.tblPayrolls)
                .HasForeignKey(d => d.EmpId);

        }
    }
}
