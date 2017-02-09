using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAssetCategoryAttribute
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public long AttributeType { get; set; }
        public long OrgId { get; set; }
        public virtual tblAssetCategory tblAssetCategory { get; set; }
        public virtual tblAttributeType tblAttributeType { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
