using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblFeeInstallmentDetailMap : EntityTypeConfiguration<tblFeeInstallmentDetail>
    {
        public tblFeeInstallmentDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblFeeInstallmentDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.InstallmentOrder).HasColumnName("InstallmentOrder");
            this.Property(t => t.DurationDays).HasColumnName("DurationDays");
            this.Property(t => t.MinFeeAmount).HasColumnName("MinFeeAmount");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblCourse)
                .WithMany(t => t.tblFeeInstallmentDetails)
                .HasForeignKey(d => d.CourseId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblFeeInstallmentDetails)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
