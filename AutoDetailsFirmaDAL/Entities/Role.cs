

using Microsoft.AspNetCore.Identity;

namespace AutoDetailsFirmaDAL.Entities
{
    public class Role : IdentityRole<int>
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
    }
}
