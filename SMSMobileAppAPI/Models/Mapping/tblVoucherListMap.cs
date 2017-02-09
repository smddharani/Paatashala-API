using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblVoucherListMap : EntityTypeConfiguration<tblVoucherList>
    {
        public tblVoucherListMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblVoucherList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.MasterVoucherId).HasColumnName("MasterVoucherId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblMasterVoucherList)
                .WithMany(t => t.tblVoucherLists)
                .HasForeignKey(d => d.MasterVoucherId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblVoucherLists)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
