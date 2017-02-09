using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblMasterVoucherListMap : EntityTypeConfiguration<tblMasterVoucherList>
    {
        public tblMasterVoucherListMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.VoucherName)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblMasterVoucherList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.VoucherName).HasColumnName("VoucherName");
        }
    }
}
