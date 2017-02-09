using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblSubCasteMap : EntityTypeConfiguration<tblSubCaste>
    {
        public tblSubCasteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblSubCaste");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentCaste).HasColumnName("ParentCaste");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblCaste)
                .WithMany(t => t.tblSubCastes)
                .HasForeignKey(d => d.ParentCaste);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblSubCastes)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
