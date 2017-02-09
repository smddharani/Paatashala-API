using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblQuestionBankMap : EntityTypeConfiguration<tblQuestionBank>
    {
        public tblQuestionBankMap()
        {
            // Primary Key
            this.HasKey(t => t.QBankId);

            // Properties
            this.Property(t => t.QuestionHTML)
                .IsRequired();

            this.Property(t => t.AnswerHTML)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("tblQuestionBank");
            this.Property(t => t.QBankId).HasColumnName("QBankId");
            this.Property(t => t.TopicId).HasColumnName("TopicId");
            this.Property(t => t.QuestionHTML).HasColumnName("QuestionHTML");
            this.Property(t => t.AnswerHTML).HasColumnName("AnswerHTML");
            this.Property(t => t.OrgId).HasColumnName("OrgId");
            this.Property(t => t.MarksForQuestion).HasColumnName("MarksForQuestion");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblQuestionBanks)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblTopic)
                .WithMany(t => t.tblQuestionBanks)
                .HasForeignKey(d => d.TopicId);

        }
    }
}
