using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAttendanceHourlyMap : EntityTypeConfiguration<tblAttendanceHourly>
    {
        public tblAttendanceHourlyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblAttendanceHourly");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.IsPickUp).HasColumnName("IsPickUp");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblAttendanceHourlies)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStudent)
                .WithMany(t => t.tblAttendanceHourlies)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
