using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblPermissionValueDetail
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<long> StartValue { get; set; }
    }
}
