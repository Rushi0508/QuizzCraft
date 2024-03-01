using QuizCraft;
using QuizzCraft.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraft
{
    public class QuizzContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<Quiz>  Quizzes { get; set; }

        public QuizzContext() : base("QuizzConnection")
        {
            /*Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QuizzContext>()); // to sync table structure and model class*/
            /* Database.SetInitializer(new DropCreateDatabaseAlways<QuizzContext>()); // to sync table structure and model class*/
        }
        
    }
}
