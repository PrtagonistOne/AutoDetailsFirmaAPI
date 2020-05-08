using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaBLL.DTO
{
    public class UserChangePasswordDTO
    {
        public string NewPassword { get; set; }
        public string OldPassword { get; set; }
        public int Id { get; set; }
    }
}
