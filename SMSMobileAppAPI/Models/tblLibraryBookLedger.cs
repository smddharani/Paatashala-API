using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblLibraryBookLedger
    {
        public long Id { get; set; }
        public Nullable<bool> IsStaff { get; set; }
        public Nullable<long> PersonId { get; set; }
        public Nullable<long> BookId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<long> FineAmount { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblLibraryBook tblLibraryBook { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
