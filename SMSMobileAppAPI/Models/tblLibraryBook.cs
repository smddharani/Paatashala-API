using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblLibraryBook
    {
        public tblLibraryBook()
        {
            this.tblLibraryBookLedgers = new List<tblLibraryBookLedger>();
        }

        public long Id { get; set; }
        public string ISBN { get; set; }
        public long LibraryId { get; set; }
        public string Title { get; set; }
        public Nullable<long> Category { get; set; }
        public Nullable<long> Author { get; set; }
        public Nullable<long> Publication { get; set; }
        public Nullable<long> Edition { get; set; }
        public Nullable<long> Volume { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<bool> StudentIssue { get; set; }
        public Nullable<bool> StaffIssue { get; set; }
        public Nullable<int> MaxDays { get; set; }
        public string Series { get; set; }
        public string PlaceOfPublication { get; set; }
        public string BookCode { get; set; }
        public Nullable<long> NoOfPages { get; set; }
        public string Comments { get; set; }
        public string ShelfNumber { get; set; }
        public string BookPosition { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsIssued { get; set; }
        public Nullable<long> NumberOfCopies { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblLibrary tblLibrary { get; set; }
        public virtual tblLibraryBookAuthor tblLibraryBookAuthor { get; set; }
        public virtual tblLibraryBookCategory tblLibraryBookCategory { get; set; }
        public virtual tblLibraryBookEdition tblLibraryBookEdition { get; set; }
        public virtual tblLibraryBookPublication tblLibraryBookPublication { get; set; }
        public virtual tblLibraryBookVolume tblLibraryBookVolume { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblLibraryBookLedger> tblLibraryBookLedgers { get; set; }
    }
}
