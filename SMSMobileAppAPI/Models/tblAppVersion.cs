using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAppVersion
    {
        public long VersionId { get; set; }
        public Nullable<System.DateTime> BuidDate { get; set; }
        public string Version { get; set; }
        public string UpdateMessage { get; set; }
        public string Notes { get; set; }
    }
}
