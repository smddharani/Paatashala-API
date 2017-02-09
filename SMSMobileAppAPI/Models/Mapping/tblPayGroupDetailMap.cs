using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblPayGroupDetailMap : EntityTypeConfiguration<tblPayGroupDetail>
    {
        public tblPayGroupDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblPayGroupDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PayGroupId).HasColumnName("PayGroupId");
            this.Property(t => t.SalaryComponent).HasColumnName("SalaryComponent");
            this.Property(t => t.CalculationType).HasColumnName("CalculationType");
            this.Property(t => t.ComputedOn).HasColumnName("ComputedOn");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblEmployeeSalaryComponent)
                .WithMany(t => t.tblPayGroupDetails)
                .HasForeignKey(d => d.SalaryComponent);
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblPayGroupDetails)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblPayGroup)
                .WithMany(t => t.tblPayGroupDetails)
                .HasForeignKey(d => d.PayGroupId);

        }
    }
}
