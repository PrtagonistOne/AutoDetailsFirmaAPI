using AutoDetailsFirmaDAL.Entities;
using Microsoft.AspNet.Identity;

namespace AutoDetailsFirmaDAL.Identity
{
    public class AppUserManager : UserManager<AppUser>
    {
        public AppUserManager(IUserStore<AppUser> store)
            :base(store)
        {

        }
    }
}
