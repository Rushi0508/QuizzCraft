using QuizzCraftService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraftService.Services
{
    public class UserService : IUserService
    {
        private readonly QuizzDbContext quizzContext;

        public UserService()
        {
            quizzContext = new QuizzDbContext(); // Initialize QuizzContext
        }
        public string AddUser(User user)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {

                    user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password, 10);


                    qc.Users.Add(user);
                    qc.SaveChanges();

                }

                return user.Name;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
