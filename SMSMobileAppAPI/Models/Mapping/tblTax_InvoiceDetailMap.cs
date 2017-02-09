using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTax_InvoiceDetailMap : EntityTypeConfiguration<tblTax_InvoiceDetail>
    {
        public tblTax_InvoiceDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblTax_InvoiceDetail");
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
