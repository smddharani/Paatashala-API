using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblEmployeeAdditionalInfoMap : EntityTypeConfiguration<tblEmployeeAdditionalInfo>
    {
        public tblEmployeeAdditionalInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Col1)
                .HasMaxLength(50);

            this.Property(t => t.Col2)
                .HasMaxLength(50);

            this.Property(t => t.Col3)
                .HasMaxLength(50);

            this.Property(t => t.Col4)
                .HasMaxLength(50);

            this.Property(t => t.Col5)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblEmployeeAdditionalInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.Col1).HasColumnName("Col1");
            this.Property(t => t.Col1Details).HasColumnName("Col1Details");
            this.Property(t => t.Col2).HasColumnName("Col2");
            this.Property(t => t.Col2Details).HasColumnName("Col2Details");
            this.Property(t => t.Col3).HasColumnName("Col3");
            this.Property(t => t.Col3Details).HasColumnName("Col3Details");
            this.Property(t => t.Col4).HasColumnName("Col4");
            this.Property(t => t.Col4Details).HasColumnName("Col4Details");
            this.Property(t => t.Col5).HasColumnName("Col5");
            this.Property(t => t.Col5Details).HasColumnName("Col5Details");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblEmployee)
                .WithMany(t => t.tblEmployeeAdditionalInfoes)
                .HasForeignKey(d => d.EmpId);
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblEmployeeAdditionalInfoes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
