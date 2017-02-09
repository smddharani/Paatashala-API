using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblBarCodeSymbology
    {
        public tblBarCodeSymbology()
        {
            this.tblGlobalOrgSettings = new List<tblGlobalOrgSetting>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Value { get; set; }
        public virtual ICollection<tblGlobalOrgSetting> tblGlobalOrgSettings { get; set; }
    }
}
