using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class CounsellorNoteMap : EntityTypeConfiguration<CounsellorNote>
    {
        public CounsellorNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("CounsellorNotes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CounsellorId).HasColumnName("CounsellorId");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.DateOfCounselling).HasColumnName("DateOfCounselling");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblCounsellor)
                .WithMany(t => t.CounsellorNotes)
                .HasForeignKey(d => d.CounsellorId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.CounsellorNotes)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStudent)
                .WithMany(t => t.CounsellorNotes)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
