using QuizzCraft.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace QuizzCraft.Services
{
    [ServiceContract]
    public interface IUserAnswerService
    {
        [OperationContract]
        UserAnswer GetUserAnswerById(int answerId);

        [OperationContract]
        List<UserAnswer> GetUserAnswersByAttempt(int attemptId);

        [OperationContract]
        void AddUserAnswer(UserAnswer userAnswer);

        [OperationContract]
        void UpdateUserAnswer(UserAnswer userAnswer);

        [OperationContract]
        void DeleteUserAnswer(int answerId);
    }

}
