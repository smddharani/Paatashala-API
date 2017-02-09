using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTopicMap : EntityTypeConfiguration<tblTopic>
    {
        public tblTopicMap()
        {
            // Primary Key
            this.HasKey(t => t.TopicId);

            // Properties
            this.Property(t => t.TopicName)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("tblTopic");
            this.Property(t => t.TopicId).HasColumnName("TopicId");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.TopicName).HasColumnName("TopicName");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTopics)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblSubject)
                .WithMany(t => t.tblTopics)
                .HasForeignKey(d => d.SubjectId);

        }
    }
}
