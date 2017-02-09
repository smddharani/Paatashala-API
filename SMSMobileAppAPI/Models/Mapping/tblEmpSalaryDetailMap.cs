using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblEmpSalaryDetailMap : EntityTypeConfiguration<tblEmpSalaryDetail>
    {
        public tblEmpSalaryDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BankLedgerNo)
                .HasMaxLength(50);

            this.Property(t => t.PFNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblEmpSalaryDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.DeptId).HasColumnName("DeptId");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.DateOfAppointment).HasColumnName("DateOfAppointment");
            this.Property(t => t.CategoryCode).HasColumnName("CategoryCode");
            this.Property(t => t.BankAccountNo).HasColumnName("BankAccountNo");
            this.Property(t => t.BankLedgerNo).HasColumnName("BankLedgerNo");
            this.Property(t => t.DateOfConfirmation).HasColumnName("DateOfConfirmation");
            this.Property(t => t.IsEligibleForPF).HasColumnName("IsEligibleForPF");
            this.Property(t => t.BasicSalary).HasColumnName("BasicSalary");
            this.Property(t => t.PFNo).HasColumnName("PFNo");
            this.Property(t => t.IncrementAmt).HasColumnName("IncrementAmt");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblEmployee)
                .WithMany(t => t.tblEmpSalaryDetails)
                .HasForeignKey(d => d.EmpId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblEmpSalaryDetails)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
