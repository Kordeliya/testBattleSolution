using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiceBattleShips.Configuration
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("MyContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }

    }
}