using QuizzCraft.Models;
using QuizzCraft;
using System;
using System.ServiceModel;
namespace QuizCraft
{

    public class UserService : IUserService
    {
        public QuizzCraft.Models.User GetUserById(int userId)
        {
            // Implement logic to retrieve user by ID from the database
            throw new NotImplementedException();
        }

        public QuizzCraft.Models.User GetUserByEmail(string email)
        {
            // Implement logic to retrieve user by email from the database
            throw new NotImplementedException();
        }

        public void AddUser(QuizzCraft.Models.User user)
        {
            // Implement logic to add a new user to the database
            throw new NotImplementedException();
        }

        public void UpdateUser(QuizzCraft.Models.User user)
        {
            // Implement logic to update user information in the database
            throw new NotImplementedException();
        }

        public void DeleteUser(int userId)
        {
            // Implement logic to delete a user from the database
            throw new NotImplementedException();
        }
    }
}
