using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAppVersionMap : EntityTypeConfiguration<tblAppVersion>
    {
        public tblAppVersionMap()
        {
            // Primary Key
            this.HasKey(t => t.VersionId);

            // Properties
            this.Property(t => t.Version)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.UpdateMessage)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblAppVersion");
            this.Property(t => t.VersionId).HasColumnName("VersionId");
            this.Property(t => t.BuidDate).HasColumnName("BuidDate");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.UpdateMessage).HasColumnName("UpdateMessage");
            this.Property(t => t.Notes).HasColumnName("Notes");
        }
    }
}
