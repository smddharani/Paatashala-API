using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblBlockCCEMap : EntityTypeConfiguration<tblBlockCCE>
    {
        public tblBlockCCEMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblBlockCCE");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FormativeAssessmentId).HasColumnName("FormativeAssessmentId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblFormativeAssessmentCCE)
                .WithMany(t => t.tblBlockCCEs)
                .HasForeignKey(d => d.FormativeAssessmentId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblBlockCCEs)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
