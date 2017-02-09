using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblImageGallery
    {
        public long Id { get; set; }
        public long EmpId { get; set; }
        public string ImageData { get; set; }
        public string ImageName { get; set; }
        public Nullable<long> ImageSize { get; set; }
        public Nullable<long> OrgId { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblOrg tblOrg { get; set; }
    }
}
