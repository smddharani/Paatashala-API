using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblGRN_Direct_HeaderMap : EntityTypeConfiguration<tblGRN_Direct_Header>
    {
        public tblGRN_Direct_HeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblGRN_Direct_Header");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
