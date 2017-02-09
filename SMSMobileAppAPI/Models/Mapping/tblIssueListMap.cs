using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblIssueListMap : EntityTypeConfiguration<tblIssueList>
    {
        public tblIssueListMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblIssueList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.LoggedBy).HasColumnName("LoggedBy");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblLogin)
                .WithMany(t => t.tblIssueLists)
                .HasForeignKey(d => d.LoggedBy);
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblIssueLists)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
