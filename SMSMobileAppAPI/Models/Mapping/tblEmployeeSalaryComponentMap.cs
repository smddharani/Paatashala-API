using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblEmployeeSalaryComponentMap : EntityTypeConfiguration<tblEmployeeSalaryComponent>
    {
        public tblEmployeeSalaryComponentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ComponentName)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("tblEmployeeSalaryComponent");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ComponentName).HasColumnName("ComponentName");
            this.Property(t => t.IsDeduction).HasColumnName("IsDeduction");
            this.Property(t => t.IsEarning).HasColumnName("IsEarning");
            this.Property(t => t.Percentage).HasColumnName("Percentage");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblEmployeeSalaryComponents)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
