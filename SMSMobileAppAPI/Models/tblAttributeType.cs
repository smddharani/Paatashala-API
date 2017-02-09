using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAttributeType
    {
        public tblAttributeType()
        {
            this.tblAssetCategoryAttributes = new List<tblAssetCategoryAttribute>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<tblAssetCategoryAttribute> tblAssetCategoryAttributes { get; set; }
    }
}
