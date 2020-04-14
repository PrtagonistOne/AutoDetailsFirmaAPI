using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Entities
{
    public class AppUser : IdentityUser
    {
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
