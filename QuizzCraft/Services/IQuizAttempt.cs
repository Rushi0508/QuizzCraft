using System;
using QuizzCraft.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace QuizzCraft.Services
{
   

    [ServiceContract]
    public interface IQuizAttemptService
    {
        [OperationContract]
        QuizAttempt GetQuizAttemptById(int attemptId);

        [OperationContract]
        List<QuizAttempt> GetQuizAttemptsByUser(int userId);

        [OperationContract]
        void StartQuizAttempt(int userId, int quizId);

        [OperationContract]
        void SubmitQuizAttempt(QuizAttempt quizAttempt);

        [OperationContract]
        void CancelQuizAttempt(int attemptId);
    }

}
