using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace MvcidentityBank
{
    public class CustomUser:IdentityUser
    {
        public string SkinColor { get; set; }

        public DateTime LastVisit { get; set; }

        //navigation property
        public virtual ICollection<Account> Accounts { get; set; }
    }
}