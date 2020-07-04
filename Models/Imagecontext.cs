using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Image.Models
{
    public class Imagecontext : DbContext
    {

        public DbSet<uploadimage> upimg { get; set; }
        public DbSet<displayimage> disimg { get; set; }
    }
}