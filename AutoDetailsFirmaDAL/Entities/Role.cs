

using Microsoft.AspNetCore.Identity;

namespace AutoDetailsFirmaDAL.Entities
{
    public class Role : IdentityRole<int>
    {
        public override string Name { get; set; }
    }
}
