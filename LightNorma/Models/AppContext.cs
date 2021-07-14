using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LightNorma.Model
{
    public class AppContext:DbContext
    {
        public DbSet<SP52dot13330Constant> SP52dot13330Constants { get; set; }
        public AppContext(DbContextOptions<AppContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
