using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblGRN_Direct_DetailMap : EntityTypeConfiguration<tblGRN_Direct_Detail>
    {
        public tblGRN_Direct_DetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.Unit)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblGRN_Direct_Detail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HeaderId).HasColumnName("HeaderId");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.PricePerUnit).HasColumnName("PricePerUnit");
            this.Property(t => t.DiscountAmt).HasColumnName("DiscountAmt");
            this.Property(t => t.TaxAmount).HasColumnName("TaxAmount");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.OrgId).HasColumnName("OrgId");
        }
    }
}
