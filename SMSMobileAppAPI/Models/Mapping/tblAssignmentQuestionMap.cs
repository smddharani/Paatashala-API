using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAssignmentQuestionMap : EntityTypeConfiguration<tblAssignmentQuestion>
    {
        public tblAssignmentQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblAssignmentQuestions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AssignmentId).HasColumnName("AssignmentId");
            this.Property(t => t.Question).HasColumnName("Question");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblAssignment)
                .WithMany(t => t.tblAssignmentQuestions)
                .HasForeignKey(d => d.AssignmentId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblAssignmentQuestions)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
