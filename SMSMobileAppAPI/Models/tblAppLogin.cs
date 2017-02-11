using System;
using System.Collections.Generic;

namespace SMSMobileAppAPI.Models
{
    public partial class tblAppLogin
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Passcode { get; set; }
        public Nullable<System.DateTime> ValidTill { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<bool> IsRegistered { get; set; }
        public string SenderId { get; set; }
    }
}
