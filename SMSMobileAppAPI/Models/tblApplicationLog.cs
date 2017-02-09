using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblApplicationLog
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string RouteData { get; set; }
        public string UserType { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<long> OrgId { get; set; }
    }
}
