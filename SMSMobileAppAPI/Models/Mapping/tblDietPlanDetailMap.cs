using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblDietPlanDetailMap : EntityTypeConfiguration<tblDietPlanDetail>
    {
        public tblDietPlanDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UOM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblDietPlanDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DietId).HasColumnName("DietId");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.UOM).HasColumnName("UOM");
            this.Property(t => t.Course).HasColumnName("Course");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblCourse)
                .WithMany(t => t.tblDietPlanDetails)
                .HasForeignKey(d => d.Course);
            this.HasRequired(t => t.tblDietaryItem)
                .WithMany(t => t.tblDietPlanDetails)
                .HasForeignKey(d => d.Item);
            this.HasRequired(t => t.tblDietPlan)
                .WithMany(t => t.tblDietPlanDetails)
                .HasForeignKey(d => d.DietId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblDietPlanDetails)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
