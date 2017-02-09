using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblCircularMap : EntityTypeConfiguration<tblCircular>
    {
        public tblCircularMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Notice)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("tblCircular");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Dated).HasColumnName("Dated");
            this.Property(t => t.Notice).HasColumnName("Notice");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblCirculars)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
