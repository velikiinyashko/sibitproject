using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sibitproject.Models
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<News> News { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
