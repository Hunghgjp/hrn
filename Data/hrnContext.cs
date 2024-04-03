using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hrn.Models;

namespace hrn.Data
{
    public class hrnContext : DbContext
    {
        public hrnContext (DbContextOptions<hrnContext> options)
            : base(options)
        {
        }

        public DbSet<hrn.Models.Employee> Employee { get; set; } = default!;
    }
}
