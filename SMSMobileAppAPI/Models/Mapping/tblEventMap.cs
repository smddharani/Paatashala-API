using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblEventMap : EntityTypeConfiguration<tblEvent>
    {
        public tblEventMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblEvent");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.EventType).HasColumnName("EventType");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblEventType)
                .WithMany(t => t.tblEvents)
                .HasForeignKey(d => d.EventType);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblEvents)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
