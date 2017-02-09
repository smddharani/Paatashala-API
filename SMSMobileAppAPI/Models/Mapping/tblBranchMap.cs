using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblBranchMap : EntityTypeConfiguration<tblBranch>
    {
        public tblBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblBranch");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.InstId).HasColumnName("InstId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblInstitution)
                .WithMany(t => t.tblBranches)
                .HasForeignKey(d => d.InstId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblBranches)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
