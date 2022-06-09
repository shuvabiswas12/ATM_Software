using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Database
{
    public class CustomIdentityUser : IdentityUser
    {
        public string NationalID { get; set; }
        public string LoginID { get; set; }
    }
}
