using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblStockItem
    {
        public tblStockItem()
        {
            this.tblPurchaseOrderDetails = new List<tblPurchaseOrderDetail>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<long> UnitOfMeasure { get; set; }
        public long StockGroup { get; set; }
        public Nullable<decimal> OpeningStock { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblPurchaseOrderDetail> tblPurchaseOrderDetails { get; set; }
        public virtual tblStockGroup tblStockGroup { get; set; }
        public virtual tblUnitOfMeasure tblUnitOfMeasure { get; set; }
    }
}
