using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MyMigration : DbMigrationsConfiguration<MyContext>
    {
        public MyMigration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyContext context)
        {
           
        }
    }
}
