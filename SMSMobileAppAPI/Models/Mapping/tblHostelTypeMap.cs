using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblHostelTypeMap : EntityTypeConfiguration<tblHostelType>
    {
        public tblHostelTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblHostelType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblHostelTypes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
