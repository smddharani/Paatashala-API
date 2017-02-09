using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTimeTableMap : EntityTypeConfiguration<tblTimeTable>
    {
        public tblTimeTableMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("tblTimeTable");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Course).HasColumnName("Course");
            this.Property(t => t.Batch).HasColumnName("Batch");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTimeTables)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
