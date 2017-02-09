using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblLibraryBookLedgerMap : EntityTypeConfiguration<tblLibraryBookLedger>
    {
        public tblLibraryBookLedgerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tblLibraryBookLedger");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IsStaff).HasColumnName("IsStaff");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.BookId).HasColumnName("BookId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.ReturnDate).HasColumnName("ReturnDate");
            this.Property(t => t.FineAmount).HasColumnName("FineAmount");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasOptional(t => t.tblLibraryBook)
                .WithMany(t => t.tblLibraryBookLedgers)
                .HasForeignKey(d => d.BookId);
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblLibraryBookLedgers)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
