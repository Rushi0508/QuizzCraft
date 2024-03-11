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

        public User GetUserByEmail(string email)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    User user = qc.Users.FirstOrDefault(u => u.Email == email);

                    // If possible, Remove password from teacher 

                    return user;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();

                return null;
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    User user = qc.Users.FirstOrDefault(u => u.UserId == id);

                    // If possible, Remove password from user

                    return user;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();

                return null;
            }
        }

        public string UpdateUser(User user)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    // Find the existing quiz in the database
                    var existingUser = qc.Users.Find(user.UserId);
                    

                    if (existingUser != null)
                    {
                        existingUser.Points += user.Points;
                        existingUser.AttemptedQuizzes += user.AttemptedQuizzes;

                        // Save changes to the database
                        qc.SaveChanges();

                        return existingUser.Name + "Your Points Updated.";
                    }
                    else
                    {
                        return "User Not Found";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Assuming that after checking exsistance of mail we do verification 
        public User VerifyUser(string email, string ePassword)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    User user = qc.Users.FirstOrDefault(u => u.Email == email);

                    bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(ePassword, user.Password);

                    if (isPasswordCorrect)
                    {
                        return user;
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                ex.ToString();

                return null;
            }
        }


    }
}
