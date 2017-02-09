using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblSubBlockCCEMap : EntityTypeConfiguration<tblSubBlockCCE>
    {
        public tblSubBlockCCEMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("tblSubBlockCCE");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BlockId).HasColumnName("BlockId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblBlockCCE)
                .WithMany(t => t.tblSubBlockCCEs)
                .HasForeignKey(d => d.BlockId);
            this.HasRequired(t => t.tblOrg)
                .WithMany(t => t.tblSubBlockCCEs)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
