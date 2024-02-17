using QuizzCraft.Models;
using QuizzCraft.Services;
using System.Collections.Generic;
using System;
using System.ServiceModel;
using QuizzCraft;
using System.Linq;

namespace QuizCraft
{

    public class QuestionService : IQuestionService
    {

        private readonly QuizzContext quizzContext;
        public QuestionService()
        {
            quizzContext = new QuizzContext(); // Initialize QuizzContext
        }

        public Question GetQuestionById(int questionId)
        {
            // Implement logic to retrieve a question by ID from the database
            return quizzContext.Questions.FirstOrDefault(q => q.QuestionID == questionId);
        }

        public List<Question> GetQuestionsByQuiz(int quizId)
        {
            // Implement logic to retrieve questions by quiz ID from the database
            throw new NotImplementedException();
        }

        public string AddQuestion(QuizzCraft.Models.Question question)
        {
            // Implement logic to add a new question to the database
            
            Question question1 = new Question();

            question1.CorrectAnswer = question.CorrectAnswer;
            question1.QuestionText = question.QuestionText;

            // Initialize Options collection if it's not initialized yet
            question1.Options = new List<string>();

            // Add options to the collection
            foreach (var option in question.Options)
            {
                question1.Options.Add(option);
            }


            quizzContext.Questions.Add(question1);
            quizzContext.SaveChanges();

            return "Done Man";
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
