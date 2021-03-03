using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace RoleForCore.Models
{
    public class CrudInCoreContext: IdentityDbContext
    {
        public CrudInCoreContext(DbContextOptions<CrudInCoreContext> options) : base(options)
        {

        }
    }
}
