using Microsoft.AspNetCore.Identity;

namespace AutoDetailsFirmaDAL.Entities
{
    public class User : IdentityUser<int>
    {
        public int Year { set; get; }
    }
}
