using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAsset
    {
        public tblAsset()
        {
            this.tblAssetAttributes = new List<tblAssetAttribute>();
            this.tblAssets1 = new List<tblAsset>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long AssetCategory { get; set; }
        public Nullable<long> ParentAssetId { get; set; }
        public long OrgId { get; set; }
        public virtual ICollection<tblAssetAttribute> tblAssetAttributes { get; set; }
        public virtual tblAssetCategory tblAssetCategory { get; set; }
        public virtual ICollection<tblAsset> tblAssets1 { get; set; }
        public virtual tblAsset tblAsset1 { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
