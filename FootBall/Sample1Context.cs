using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FBLCodeFrst.Models
{
    public class Sample1Context : DbContext
    {
        public Sample1Context()
            :base("name=Sample2Connection")
        {

        }

        public DbSet<Match> MatchTable { get; set; } 
    }
}