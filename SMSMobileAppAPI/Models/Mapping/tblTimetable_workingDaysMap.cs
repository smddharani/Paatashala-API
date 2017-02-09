using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTimetable_workingDaysMap : EntityTypeConfiguration<tblTimetable_workingDays>
    {
        public tblTimetable_workingDaysMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblTimetable_workingDays");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Sunday).HasColumnName("Sunday");
            this.Property(t => t.Monday).HasColumnName("Monday");
            this.Property(t => t.Tuesday).HasColumnName("Tuesday");
            this.Property(t => t.Wednesday).HasColumnName("Wednesday");
            this.Property(t => t.Thrusday).HasColumnName("Thrusday");
            this.Property(t => t.Friday).HasColumnName("Friday");
            this.Property(t => t.Saturday).HasColumnName("Saturday");
            this.Property(t => t.TimetableId).HasColumnName("TimetableId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTimetable_workingDays)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
