using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using salleswebmvc.Models;

namespace salleswebmvc.Data
{
    public class salleswebmvcContext : DbContext
    {
        public salleswebmvcContext (DbContextOptions<salleswebmvcContext> options)
            : base(options)
        {
        }

        public DbSet<salleswebmvc.Models.Department> Department { get; set; }
    }
}
