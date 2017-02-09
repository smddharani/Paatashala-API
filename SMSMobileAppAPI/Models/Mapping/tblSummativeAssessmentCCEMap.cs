using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblSummativeAssessmentCCEMap : EntityTypeConfiguration<tblSummativeAssessmentCCE>
    {
        public tblSummativeAssessmentCCEMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblSummativeAssessmentCCE");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TermId).HasColumnName("TermId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblSummativeAssessmentCCEs)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblTermCCE)
                .WithMany(t => t.tblSummativeAssessmentCCEs)
                .HasForeignKey(d => d.TermId);

        }
    }
}
