using QuizzCraft.Models;
using QuizzCraft.Services;
using System.Collections.Generic;
using System;
using System.ServiceModel;
using QuizzCraft;
using System.Linq;

namespace QuizCraft
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
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
            
            var questionsByQuiz = quizzContext.Questions.Where(q => q.QuizId == quizId).ToList();

            return questionsByQuiz;
        }

        public string AddQuestion(QuizzCraft.Models.Question question, QuizzCraft.Models.Option option)
        {
            // Implement logic to add a new question to the database

            question.QuizId =  1;// Id from created Quizz 
            question.Option = option;

            quizzContext.Questions.Add(question);
            quizzContext.SaveChanges();

            return "Done";
        }

        public void UpdateQuestion(Question question)
        {
            // Implement logic to update question information in the database
            throw new NotImplementedException();
        }

        public void DeleteQuestion(int questionId)
        {
            // Implement logic to delete a question from the database

            var questionToDelete = quizzContext.Questions.Include("Option").FirstOrDefault(q => q.QuestionID == questionId);

            if (questionToDelete != null)
            {
                // Remove the associated option first
                
                quizzContext.Options.Remove(questionToDelete.Option);
                

                // Then remove the question itself
                quizzContext.Questions.Remove(questionToDelete);

                quizzContext.SaveChanges(); // Save changes to the database
            }

        }
    }
}
