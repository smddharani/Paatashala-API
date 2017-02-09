using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblCourseFeeDetailMap : EntityTypeConfiguration<tblCourseFeeDetail>
    {
        public tblCourseFeeDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TemplateName)
                .HasMaxLength(200);

            this.Property(t => t.UOM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblCourseFeeDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TemplateName).HasColumnName("TemplateName");
            this.Property(t => t.Course).HasColumnName("Course");
            this.Property(t => t.Batch).HasColumnName("Batch");
            this.Property(t => t.FeeItem).HasColumnName("FeeItem");
            this.Property(t => t.UOM).HasColumnName("UOM");
            this.Property(t => t.RatePerUnit).HasColumnName("RatePerUnit");
            this.Property(t => t.BillingType).HasColumnName("BillingType");
            this.Property(t => t.StandardRate).HasColumnName("StandardRate");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblBatch)
                .WithMany(t => t.tblCourseFeeDetails)
                .HasForeignKey(d => d.Batch);
            this.HasRequired(t => t.tblCourse)
                .WithMany(t => t.tblCourseFeeDetails)
                .HasForeignKey(d => d.Course);
            this.HasRequired(t => t.tblFeeItemDetail)
                .WithMany(t => t.tblCourseFeeDetails)
                .HasForeignKey(d => d.FeeItem);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblCourseFeeDetails)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
