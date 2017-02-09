using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTransportPaymentMap : EntityTypeConfiguration<tblTransportPayment>
    {
        public tblTransportPaymentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblTransportPayment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTransportPayments)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
