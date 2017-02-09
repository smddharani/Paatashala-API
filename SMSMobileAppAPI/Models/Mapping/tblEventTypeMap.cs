using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblEventTypeMap : EntityTypeConfiguration<tblEventType>
    {
        public tblEventTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblEventType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.PersonType).HasColumnName("PersonType");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblEventTypes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
