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
    public interface IQuizService
    {

        [OperationContract]
        string AddQuiz(Quiz quiz, string email);
        
        [OperationContract]
        void DeleteQuiz(int quizId);

        [OperationContract]
        List <Quiz> GetAllQuizzes();

        [OperationContract]
        List <Quiz> GetMyQuizzes(string email);

        [OperationContract]
        Quiz GetQuiz(int quizId);

        [OperationContract]
        string UpdateQuiz(Quiz quiz);


    }
}
