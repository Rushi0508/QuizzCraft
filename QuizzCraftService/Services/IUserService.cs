using QuizzCraftService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraftService.Services
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        string AddUser(User user);

        [OperationContract]
        User GetUserByEmail(string email);

        [OperationContract]
        User VerifyUser(string email, string password);

        [OperationContract]
        User GetUserById(int id);

        [OperationContract]
        string UpdateUser(User user);

        [OperationContract]

        List<User> GetAllUsers();
    }
}
