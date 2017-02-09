using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblLibraryMap : EntityTypeConfiguration<tblLibrary>
    {
        public tblLibraryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblLibrary");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.IsWithinPremises).HasColumnName("IsWithinPremises");
            this.Property(t => t.BooksCapacity).HasColumnName("BooksCapacity");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblLibraries)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
