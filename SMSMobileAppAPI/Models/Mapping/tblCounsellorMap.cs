using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblCounsellorMap : EntityTypeConfiguration<tblCounsellor>
    {
        public tblCounsellorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("tblCounsellor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblCounsellors)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
