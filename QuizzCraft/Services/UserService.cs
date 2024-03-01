using QuizzCraft.Models;
using QuizzCraft;
using System;
using System.ServiceModel;
using BCrypt;
using System.Text.RegularExpressions;
using System.Security.Principal;
using System.Linq;

namespace QuizCraft
{

    public class UserService : IUserService
    {
        private readonly QuizzContext quizzContext;

        public UserService()
        {
            quizzContext = new QuizzContext(); // Initialize QuizzContext
        }

        public QuizzCraft.Models.User GetUserById(int userId)
        {
            // Implement logic to retrieve user by ID from the database
            return quizzContext.Users.FirstOrDefault(u => u.UserId== userId);

        }

        public QuizzCraft.Models.User GetUserByEmail(string email)
        {
            // Implement logic to retrieve user by email from the database
            return quizzContext.Users.FirstOrDefault(u => u.Email == email);
        }
        private bool UserExists(string email)
        {
            return true;
            // Replace this with logic to check if a user with the given email exists in your database
        }

        public void AddUser(QuizzCraft.Models.User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password, 10);

            quizzContext.Users.Add(user);
            quizzContext.SaveChanges();

            return;

            /*if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ArgumentException("Email cannot be empty or null.", nameof(user.Email));
            }
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Password cannot be empty or null.", nameof(user.Password));
            }
            if (string.IsNullOrWhiteSpace(user.Name))
            {
                throw new ArgumentException("Name cannot be empty or null.", nameof(user.Name));
            }

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(user.Email, pattern))
            {
                throw new ArgumentException("Enter a valid email", nameof(user.Name));
            }

            if (UserExists(user.Email))
            {
                throw new InvalidOperationException("User with the same email already exists.");
            }

            */

        }

        public void UpdateUser(QuizzCraft.Models.User user)
        {
            // Implement logic to update user information in the database
            throw new NotImplementedException();
        }
    }
}
