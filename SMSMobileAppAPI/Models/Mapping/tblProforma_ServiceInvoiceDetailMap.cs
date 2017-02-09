using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblProforma_ServiceInvoiceDetailMap : EntityTypeConfiguration<tblProforma_ServiceInvoiceDetail>
    {
        public tblProforma_ServiceInvoiceDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblProforma_ServiceInvoiceDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.RatePerUnit).HasColumnName("RatePerUnit");
            this.Property(t => t.DiscountAmount).HasColumnName("DiscountAmount");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.OrgId).HasColumnName("OrgId");
        }
    }
}
