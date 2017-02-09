using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblProforma_TaxInvoiceHeaderMap : EntityTypeConfiguration<tblProforma_TaxInvoiceHeader>
    {
        public tblProforma_TaxInvoiceHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CustomerName)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblProforma_TaxInvoiceHeader");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.InvoiceDate).HasColumnName("InvoiceDate");
            this.Property(t => t.PONumber).HasColumnName("PONumber");
            this.Property(t => t.PODate).HasColumnName("PODate");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.TinOrCST).HasColumnName("TinOrCST");
            this.Property(t => t.TaxType).HasColumnName("TaxType");
            this.Property(t => t.TradeDiscountPercent).HasColumnName("TradeDiscountPercent");
            this.Property(t => t.SpecialDiscount).HasColumnName("SpecialDiscount");
            this.Property(t => t.TotalTax).HasColumnName("TotalTax");
            this.Property(t => t.Total).HasColumnName("Total");
        }
    }
}
