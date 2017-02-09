using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblLeadStatuMap : EntityTypeConfiguration<tblLeadStatu>
    {
        public tblLeadStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(500);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblLeadStatus");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
