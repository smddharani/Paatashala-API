using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblLibraryBookAuthor
    {
        public tblLibraryBookAuthor()
        {
            this.tblLibraryBooks = new List<tblLibraryBook>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual ICollection<tblLibraryBook> tblLibraryBooks { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
