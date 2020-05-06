using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoDetailsFirmaDAL.Entities
{
    public class User : IdentityUser<int>
    {
        public override string Email { get; set; }
        public override string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
