using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAffiliationMap : EntityTypeConfiguration<tblAffiliation>
    {
        public tblAffiliationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblAffiliation");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
