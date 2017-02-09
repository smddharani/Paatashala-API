using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblCustomerMap : EntityTypeConfiguration<tblCustomer>
    {
        public tblCustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BalanceType)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Website)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblCustomer");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OpeningBalance).HasColumnName("OpeningBalance");
            this.Property(t => t.BalanceType).HasColumnName("BalanceType");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.TinOrLst).HasColumnName("TinOrLst");
            this.Property(t => t.CSTNumber).HasColumnName("CSTNumber");
            this.Property(t => t.TradeDiscountPercent).HasColumnName("TradeDiscountPercent");
            this.Property(t => t.CashDiscount).HasColumnName("CashDiscount");
            this.Property(t => t.TradeDiscount).HasColumnName("TradeDiscount");
            this.Property(t => t.CreditAllow).HasColumnName("CreditAllow");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblCustomers)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
