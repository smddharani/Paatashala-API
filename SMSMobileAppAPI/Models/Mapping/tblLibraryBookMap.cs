using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SMSMobileAppAPI.Models.Mapping
{
    public class tblLibraryBookMap : EntityTypeConfiguration<tblLibraryBook>
    {
        public tblLibraryBookMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Series)
                .HasMaxLength(50);

            this.Property(t => t.BookCode)
                .HasMaxLength(50);

            this.Property(t => t.ShelfNumber)
                .HasMaxLength(50);

            this.Property(t => t.BookPosition)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblLibraryBook");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ISBN).HasColumnName("ISBN");
            this.Property(t => t.LibraryId).HasColumnName("LibraryId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Author).HasColumnName("Author");
            this.Property(t => t.Publication).HasColumnName("Publication");
            this.Property(t => t.Edition).HasColumnName("Edition");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.PurchaseDate).HasColumnName("PurchaseDate");
            this.Property(t => t.StudentIssue).HasColumnName("StudentIssue");
            this.Property(t => t.StaffIssue).HasColumnName("StaffIssue");
            this.Property(t => t.MaxDays).HasColumnName("MaxDays");
            this.Property(t => t.Series).HasColumnName("Series");
            this.Property(t => t.PlaceOfPublication).HasColumnName("PlaceOfPublication");
            this.Property(t => t.BookCode).HasColumnName("BookCode");
            this.Property(t => t.NoOfPages).HasColumnName("NoOfPages");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.ShelfNumber).HasColumnName("ShelfNumber");
            this.Property(t => t.BookPosition).HasColumnName("BookPosition");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.IsIssued).HasColumnName("IsIssued");
            this.Property(t => t.NumberOfCopies).HasColumnName("NumberOfCopies");
            this.Property(t => t.OrgId).HasColumnName("OrgId");

            // Relationships
            this.HasRequired(t => t.tblLibrary)
                .WithMany(t => t.tblLibraryBooks)
                .HasForeignKey(d => d.LibraryId);
            this.HasOptional(t => t.tblLibraryBookAuthor)
                .WithMany(t => t.tblLibraryBooks)
                .HasForeignKey(d => d.Author);
            this.HasOptional(t => t.tblLibraryBookCategory)
                .WithMany(t => t.tblLibraryBooks)
                .HasForeignKey(d => d.Category);
            this.HasOptional(t => t.tblLibraryBookEdition)
                .WithMany(t => t.tblLibraryBooks)
                .HasForeignKey(d => d.Edition);
            this.HasOptional(t => t.tblLibraryBookPublication)
                .WithMany(t => t.tblLibraryBooks)
                .HasForeignKey(d => d.Publication);
            this.HasOptional(t => t.tblLibraryBookVolume)
                .WithMany(t => t.tblLibraryBooks)
                .HasForeignKey(d => d.Volume);
            this.HasOptional(t => t.tblOrg)
                .WithMany(t => t.tblLibraryBooks)
                .HasForeignKey(d => d.OrgId);

        }
    }
}
