using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAccountLedgerMap : EntityTypeConfiguration<tblAccountLedger>
    {
        public tblAccountLedgerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblAccountLedger");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AccountGroup).HasColumnName("AccountGroup");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblAccountGroup)
                .WithMany(t => t.tblAccountLedgers)
                .HasForeignKey(d => d.AccountGroup);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblAccountLedgers)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
