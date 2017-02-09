using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblPurchaseOrderHeader
    {
        public tblPurchaseOrderHeader()
        {
            this.tblPurchaseOrderDetails = new List<tblPurchaseOrderDetail>();
        }

        public long Id { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<long> TaxTypeId { get; set; }
        public long VendorId { get; set; }
        public string VendorAddress { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string PONumber { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblPurchaseOrderDetail> tblPurchaseOrderDetails { get; set; }
        public virtual tblVendor tblVendor { get; set; }
    }
}
