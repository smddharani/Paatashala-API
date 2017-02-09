using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblAttendanceMap : EntityTypeConfiguration<tblAttendance>
    {
        public tblAttendanceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblAttendance");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.P1).HasColumnName("P1");
            this.Property(t => t.P2).HasColumnName("P2");
            this.Property(t => t.P3).HasColumnName("P3");
            this.Property(t => t.P4).HasColumnName("P4");
            this.Property(t => t.P5).HasColumnName("P5");
            this.Property(t => t.P6).HasColumnName("P6");
            this.Property(t => t.P7).HasColumnName("P7");
            this.Property(t => t.P8).HasColumnName("P8");
            this.Property(t => t.P9).HasColumnName("P9");
            this.Property(t => t.P10).HasColumnName("P10");
            this.Property(t => t.TimeTableId).HasColumnName("TimeTableId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblAttendances)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblStudent)
                .WithMany(t => t.tblAttendances)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
