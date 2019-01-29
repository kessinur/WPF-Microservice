using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampADO.Context
{
    class MyContext : DbContext
    {
        public MyContext() : base("bootcamp22") { }

            //public DbSet<Supplier> Suppliers { get; set; }
            //public DbSet<Item> Items { get; set; }
        
    }
}
