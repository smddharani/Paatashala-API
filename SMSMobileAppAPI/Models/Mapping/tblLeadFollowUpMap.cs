using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblLeadFollowUpMap : EntityTypeConfiguration<tblLeadFollowUp>
    {
        public tblLeadFollowUpMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Explanation)
                .HasMaxLength(500);

            this.Property(t => t.Channel)
                .HasMaxLength(500);

            this.Property(t => t.Remarks)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tblLeadFollowUp");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.AssignTo).HasColumnName("AssignTo");
            this.Property(t => t.Explanation).HasColumnName("Explanation");
            this.Property(t => t.FollowupTime).HasColumnName("FollowupTime");
            this.Property(t => t.Channel).HasColumnName("Channel");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblEmployee)
                .WithMany(t => t.tblLeadFollowUps)
                .HasForeignKey(d => d.AssignTo);
            this.HasOptional(t => t.tblEmployee1)
                .WithMany(t => t.tblLeadFollowUps1)
                .HasForeignKey(d => d.CreatedBy);
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblLeadFollowUps)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStudent)
                .WithMany(t => t.tblLeadFollowUps)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
