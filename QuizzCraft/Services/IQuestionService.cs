using QuizzCraft.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace QuizzCraft.Services
{
    

    [ServiceContract]
    public interface IQuestionService
    {
        [OperationContract]
        Question GetQuestionById(int questionId);

        [OperationContract]
        List<Question> GetQuestionsByQuiz(int quizId);

        [OperationContract]
        void AddQuestion(Question question);

        [OperationContract]
        void UpdateQuestion(Question question);

        [OperationContract]
        void DeleteQuestion(int questionId);
    }

}
