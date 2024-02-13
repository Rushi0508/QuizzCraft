using QuizzCraft.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraft
{
    public class QuizzContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public QuizzContext() : base("QuizzConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<QuizzContext>());
        }
    }
}
