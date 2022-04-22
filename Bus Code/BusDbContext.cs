using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BusDemo.Models
{
    public class BusDbContext : DbContext
    {
        public BusDbContext()
            : base("name=BusConnection")
        {

        }

        public DbSet<BusDetails> BusDetailsTable { get; set; }
    }
}