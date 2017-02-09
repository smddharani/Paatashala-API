using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblLibraryBookAuthorMap : EntityTypeConfiguration<tblLibraryBookAuthor>
    {
        public tblLibraryBookAuthorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblLibraryBookAuthors");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblLibraryBookAuthors)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
