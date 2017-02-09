using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblLibraryBookVolume
    {
        public tblLibraryBookVolume()
        {
            this.tblLibraryBooks = new List<tblLibraryBook>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblLibraryBook> tblLibraryBooks { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
