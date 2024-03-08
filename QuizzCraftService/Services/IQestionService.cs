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
    public interface IQestionService
    {
        [OperationContract]
        string AddQuestion(Question question);

        [OperationContract]
        List<Question> GetAllQuestionsByQuiz(int quizId);

        [OperationContract]
        Question GetQuestionById(int questionId);


        [OperationContract]
        string UpdateQuestion(Question question);

        [OperationContract]
        void DeleteQuestion(int questionId);

    }
}
