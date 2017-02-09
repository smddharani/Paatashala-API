using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAssetCategory
    {
        public tblAssetCategory()
        {
            this.tblAssetCategoryAttributes = new List<tblAssetCategoryAttribute>();
            this.tblAssets = new List<tblAsset>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblAssetCategoryAttribute> tblAssetCategoryAttributes { get; set; }
        public virtual ICollection<tblAsset> tblAssets { get; set; }
    }
}
