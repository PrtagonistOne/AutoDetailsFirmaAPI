using AutoDetailsFirmaDAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AutoDetailsFirmaDAL.Identity
{
    public class AppRoleManager : RoleManager<AppRole>
    {
        public AppRoleManager(RoleStore<AppRole> store)
                    : base(store)
        { }
    }
}
