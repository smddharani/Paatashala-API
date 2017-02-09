using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblTripParticipantMap : EntityTypeConfiguration<tblTripParticipant>
    {
        public tblTripParticipantMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblTripParticipants");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.TripSheetId).HasColumnName("TripSheetId");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.PersonTypeId).HasColumnName("PersonTypeId");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblTripParticipants)
                .HasForeignKey(d => d.OrgId);
            this.HasOptional(t => t.tblTripSheet)
                .WithMany(t => t.tblTripParticipants)
                .HasForeignKey(d => d.TripSheetId);

        }
    }
}
