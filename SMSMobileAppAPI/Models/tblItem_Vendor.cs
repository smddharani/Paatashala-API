using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblItem_Vendor
    {
        public long Id { get; set; }
        public Nullable<long> VendorId { get; set; }
        public Nullable<long> ItemId { get; set; }
        public long OrgId { get; set; }
        public virtual tblItem tblItem { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual tblVendor tblVendor { get; set; }
    }
}
