using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblPayrollDetailMap : EntityTypeConfiguration<tblPayrollDetail>
    {
        public tblPayrollDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblPayrollDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PayrollId).HasColumnName("PayrollId");
            this.Property(t => t.ComponentId).HasColumnName("ComponentId");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblEmployeeSalaryComponent)
                .WithMany(t => t.tblPayrollDetails)
                .HasForeignKey(d => d.ComponentId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblPayrollDetails)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblPayroll)
                .WithMany(t => t.tblPayrollDetails)
                .HasForeignKey(d => d.PayrollId);

        }
    }
}
