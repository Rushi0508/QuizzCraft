using QuizzCraft.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;
namespace QuizzCraft.Services
{
    

    [ServiceContract]
    public interface IQuizService
    {
        [OperationContract]
        Quiz GetQuizById(int quizId);

        [OperationContract]
        List<Quiz> GetAllQuizzes();

        [OperationContract]
        List<Quiz> GetQuizzesByCreator(int creatorId);

        [OperationContract]
        void AddQuiz(Quiz quiz);

        [OperationContract]
        void UpdateQuiz(Quiz quiz);

        [OperationContract]
        void DeleteQuiz(int quizId);
    }

}
