using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStockGroup
    {
        public tblStockGroup()
        {
            this.tblPurchaseOrderDetails = new List<tblPurchaseOrderDetail>();
            this.tblStockItems = new List<tblStockItem>();
        }

        public long Id { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblPurchaseOrderDetail> tblPurchaseOrderDetails { get; set; }
        public virtual ICollection<tblStockItem> tblStockItems { get; set; }
    }
}
