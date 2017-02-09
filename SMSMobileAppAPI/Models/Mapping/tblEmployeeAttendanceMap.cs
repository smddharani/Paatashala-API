using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblEmployeeAttendanceMap : EntityTypeConfiguration<tblEmployeeAttendance>
    {
        public tblEmployeeAttendanceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblEmployeeAttendance");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.IsPresent).HasColumnName("IsPresent");
            this.Property(t => t.LeaveType).HasColumnName("LeaveType");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblEmployeeLeaveType)
                .WithMany(t => t.tblEmployeeAttendances)
                .HasForeignKey(d => d.LeaveType);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblEmployeeAttendances)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblOrg1)
                .WithMany(t => t.tblEmployeeAttendances1)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
