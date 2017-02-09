using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblHostelMap : EntityTypeConfiguration<tblHostel>
    {
        public tblHostelMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("tblHostel");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.ContactNumber).HasColumnName("ContactNumber");
            this.Property(t => t.HostelType).HasColumnName("HostelType");
            this.Property(t => t.WardenName).HasColumnName("WardenName");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblHostelType)
                .WithMany(t => t.tblHostels)
                .HasForeignKey(d => d.HostelType);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblHostels)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
