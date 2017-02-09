using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblUnitOfMeasure
    {
        public tblUnitOfMeasure()
        {
            this.tblStockItems = new List<tblStockItem>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long OrgId { get; set; }
        public virtual tblOrg tblOrg { get; set; }
        public virtual ICollection<tblStockItem> tblStockItems { get; set; }
    }
}
