using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAssetAttribute
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public string String { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Decimal { get; set; }
        public Nullable<long> Integer { get; set; }
        public long OrgId { get; set; }
        public virtual tblAsset tblAsset { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
