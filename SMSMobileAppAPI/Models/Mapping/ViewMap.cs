using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class ViewMap : EntityTypeConfiguration<View>
    {
        public ViewMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ViewName)
                .IsRequired();

            this.Property(t => t.ViewPath)
                .IsRequired();

            this.Property(t => t.ViewContent)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("View");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ViewName).HasColumnName("ViewName");
            this.Property(t => t.ViewPath).HasColumnName("ViewPath");
            this.Property(t => t.ViewContent).HasColumnName("ViewContent");
            this.Property(t => t.OrgId).HasColumnName("OrgId");
        }
    }
}
