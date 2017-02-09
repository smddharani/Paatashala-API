using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblLoginUserTypeMap : EntityTypeConfiguration<tblLoginUserType>
    {
        public tblLoginUserTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblLoginUserType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserTypeId).HasColumnName("UserTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
