using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblMasterVoucherList
    {
        public tblMasterVoucherList()
        {
            this.tblVoucherLists = new List<tblVoucherList>();
        }

        public long Id { get; set; }
        public string VoucherName { get; set; }
        public virtual ICollection<tblVoucherList> tblVoucherLists { get; set; }
    }
}
