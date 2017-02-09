using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblChallan_InvoiceHeaderMap : EntityTypeConfiguration<tblChallan_InvoiceHeader>
    {
        public tblChallan_InvoiceHeaderMap()
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
            this.ToTable("tblChallan_InvoiceHeader");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.InvoiceDate).HasColumnName("InvoiceDate");
            this.Property(t => t.PONumber).HasColumnName("PONumber");
            this.Property(t => t.PODate).HasColumnName("PODate");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.TinOrCST).HasColumnName("TinOrCST");
            this.Property(t => t.TaxType).HasColumnName("TaxType");
            this.Property(t => t.TradeDiscountPercent).HasColumnName("TradeDiscountPercent");
            this.Property(t => t.SpecialDiscountPercent).HasColumnName("SpecialDiscountPercent");
            this.Property(t => t.TotalTax).HasColumnName("TotalTax");
            this.Property(t => t.Total).HasColumnName("Total");
        }
    }
}
