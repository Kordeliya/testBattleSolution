using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MyContext : DbContext
    {
        public MyContext()
            :base()
        {
        }


        public DbSet<User> Users { get; set; }

        public DbSet<Game> Games {get; set;}
    }
}
