using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblLibraryBookPublication
    {
        public tblLibraryBookPublication()
        {
            this.tblLibraryBooks = new List<tblLibraryBook>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblLibraryBook> tblLibraryBooks { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
