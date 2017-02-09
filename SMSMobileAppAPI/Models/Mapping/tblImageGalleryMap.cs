using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblImageGalleryMap : EntityTypeConfiguration<tblImageGallery>
    {
        public tblImageGalleryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ImageName)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblImageGallery");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.ImageData).HasColumnName("ImageData");
            this.Property(t => t.ImageName).HasColumnName("ImageName");
            this.Property(t => t.ImageSize).HasColumnName("ImageSize");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblEmployee)
                .WithMany(t => t.tblImageGalleries)
                .HasForeignKey(d => d.EmpId);
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblImageGalleries)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
