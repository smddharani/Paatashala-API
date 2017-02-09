using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblStudent_CourseMap : EntityTypeConfiguration<tblStudent_Course>
    {
        public tblStudent_CourseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblStudent$Course");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
