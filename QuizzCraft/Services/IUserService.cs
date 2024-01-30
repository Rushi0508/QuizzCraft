using System;
using System.ServiceModel;
using QuizzCraft.Models;

namespace QuizzCraft
{

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User GetUserById(int userId);

        [OperationContract]
        User GetUserByEmail(string email);

        [OperationContract]
        void AddUser(User user);

        [OperationContract]
        void UpdateUser(User user);

        [OperationContract]
        void DeleteUser(int userId);
    }


}
