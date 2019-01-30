using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MVCPatternAPP.Entity.Models;

namespace MVCPatternAPP.Data.DatabaseContext
{
    public class MvcPatternDbContext:DbContext
    {
        public MvcPatternDbContext():base("DatabaseConnection")
        {
            
        }

        public DbSet<Category> Categories { get; set; }

    }
}
