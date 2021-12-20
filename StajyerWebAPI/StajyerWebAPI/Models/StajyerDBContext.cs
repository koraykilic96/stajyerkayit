using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajyerWebAPI.Models
{
    public class StajyerDBContext : DbContext
    {
        public StajyerDBContext(DbContextOptions<StajyerDBContext> options)
            : base(options)
        {
        }
        public DbSet<Stajyer> Stajyers { get; set; }
    }
}
