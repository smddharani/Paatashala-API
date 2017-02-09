using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblMasterPermissionSet
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Value { get; set; }
        public Nullable<long> ParentValue { get; set; }
    }
}
