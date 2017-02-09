using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblHostelBillingMap : EntityTypeConfiguration<tblHostelBilling>
    {
        public tblHostelBillingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblHostelBilling");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblHostelBillings)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
