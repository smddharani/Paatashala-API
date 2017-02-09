using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblLibrary
    {
        public tblLibrary()
        {
            this.tblLibraryBooks = new List<tblLibraryBook>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<bool> IsWithinPremises { get; set; }
        public Nullable<long> BooksCapacity { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblLibraryBook> tblLibraryBooks { get; set; }
    }
}
