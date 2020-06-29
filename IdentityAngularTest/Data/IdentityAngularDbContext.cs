using System;
using System.Collections.Generic;
using System.Text;
using IdentityAngularTest.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityAngularTest.Data
{
    public class IdentityAngularDbContext : IdentityDbContext<User>
    {
        public IdentityAngularDbContext(DbContextOptions<IdentityAngularDbContext> options)
            : base(options)
        {
        }
    }
}
