using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblGRN_PO_HeaderMap : EntityTypeConfiguration<tblGRN_PO_Header>
    {
        public tblGRN_PO_HeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PONo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblGRN_PO_Header");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GRNDate).HasColumnName("GRNDate");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.TaxType).HasColumnName("TaxType");
            this.Property(t => t.InvoiceNo).HasColumnName("InvoiceNo");
            this.Property(t => t.TotalTax).HasColumnName("TotalTax");
            this.Property(t => t.Total).HasColumnName("Total");
        }
    }
}
