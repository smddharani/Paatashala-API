using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblDatabaseLogMap : EntityTypeConfiguration<tblDatabaseLog>
    {
        public tblDatabaseLogMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblDatabaseLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CommandText).HasColumnName("CommandText");
            this.Property(t => t.Parameters).HasColumnName("Parameters");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");
        }
    }
}
