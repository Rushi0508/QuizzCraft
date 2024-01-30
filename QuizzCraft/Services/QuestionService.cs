using QuizzCraft.Models;
using QuizzCraft.Services;
using System.Collections.Generic;
using System;
using System.ServiceModel;
namespace QuizCraft
{

    public class QuestionService : IQuestionService
    {
        public Question GetQuestionById(int questionId)
        {
            // Implement logic to retrieve a question by ID from the database
            throw new NotImplementedException();
        }

        public List<Question> GetQuestionsByQuiz(int quizId)
        {
            // Implement logic to retrieve questions by quiz ID from the database
            throw new NotImplementedException();
        }

        public void AddQuestion(Question question)
        {
            // Implement logic to add a new question to the database
            throw new NotImplementedException();
        }

        public void UpdateQuestion(Question question)
        {
            // Implement logic to update question information in the database
            throw new NotImplementedException();
        }

        public void DeleteQuestion(int questionId)
        {
            // Implement logic to delete a question from the database
            throw new NotImplementedException();
        }
    }
}
