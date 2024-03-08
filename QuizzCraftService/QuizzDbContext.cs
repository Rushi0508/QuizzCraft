using QuizzCraftService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraftService
{
    public class QuizzDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public QuizzDbContext() : base("QuizzConnection")
        {
            /*Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QuizzDbContext>()); // to sync table structure and model class*/
            /* Database.SetInitializer(new DropCreateDatabaseAlways<QuizzContext>()); // to sync table structure and model class*/
        }

    }
}
