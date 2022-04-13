using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Software.Database
{
    public class ATMDbContext : IdentityDbContext
    {
        public ATMDbContext(DbContextOptions<ATMDbContext> options) : base(options)
        {

        }
    }
}
