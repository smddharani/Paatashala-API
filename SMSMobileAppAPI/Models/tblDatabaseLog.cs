using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblDatabaseLog
    {
        public long Id { get; set; }
        public string CommandText { get; set; }
        public string Parameters { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<long> OrgId { get; set; }
    }
}
