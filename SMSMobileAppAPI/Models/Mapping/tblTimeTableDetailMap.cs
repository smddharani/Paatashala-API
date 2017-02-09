using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTimeTableDetailMap : EntityTypeConfiguration<tblTimeTableDetail>
    {
        public tblTimeTableDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblTimeTableDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.WorkingDays).HasColumnName("WorkingDays");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTIme).HasColumnName("EndTIme");
            this.Property(t => t.TimeTableId).HasColumnName("TimeTableId");
            this.Property(t => t.FacultyId).HasColumnName("FacultyId");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTimeTableDetails)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblTimeTable)
                .WithMany(t => t.tblTimeTableDetails)
                .HasForeignKey(d => d.TimeTableId);

        }
    }
}
