using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblFeePaidDetailMap : EntityTypeConfiguration<tblFeePaidDetail>
    {
        public tblFeePaidDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblFeePaidDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FeePaidHeader).HasColumnName("FeePaidHeader");
            this.Property(t => t.FeeItemId).HasColumnName("FeeItemId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblFeeItemDetail)
                .WithMany(t => t.tblFeePaidDetails)
                .HasForeignKey(d => d.FeeItemId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblFeePaidDetails)
                .HasForeignKey(d => d.OrgId);
            this.HasRequired(t => t.tblStudentFeePaidHeader)
                .WithMany(t => t.tblFeePaidDetails)
                .HasForeignKey(d => d.FeePaidHeader);

        }
    }
}
