using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblLibraryBookPublicationMap : EntityTypeConfiguration<tblLibraryBookPublication>
    {
        public tblLibraryBookPublicationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Phone)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblLibraryBookPublication");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblLibraryBookPublications)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
