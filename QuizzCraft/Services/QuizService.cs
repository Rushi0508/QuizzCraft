using QuizzCraft;
using QuizzCraft.Models;
using QuizzCraft.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
namespace QuizCraft
{

    public class QuizService : IQuizService
    {
        private readonly QuizzContext quizzContext;

        // Get Access Of UserServices 
        private readonly UserService userService;

        public QuizService()
        {
            this.quizzContext = new QuizzContext();
            this.userService = new UserService();
        }
        public Quiz GetQuizById(int quizId)
        {
            // Implement logic to retrieve a quiz by ID from the database
            var quiz = quizzContext.Quizzes.FirstOrDefault(q => q.QuizID == quizId);

            if (quiz == null)
            {
                throw new Exception($"Quiz with ID {quizId} not found");
            }

            return quiz;
        }

        public List<Quiz> GetAllQuizzes()
        {
            // Implement logic to retrieve all quizzes from the database

            var quizzes = quizzContext.Quizzes.ToList();

             return quizzes;
        }

        public List<Quiz> GetQuizzesByCreator(int creatorId)
        {
            // Implement logic to retrieve quizzes by creator ID from the database

            const int userId = 1; // Get From Session 

            var quizzesByUser = quizzContext.Quizzes.Where(q => q.UserID == userId).ToList();

            return quizzesByUser;
        }

        public void AddQuiz(Quiz quiz)
        {
            // Implement logic to add a new quiz to the database

            string email = "san@gmail.com"; // From Session 
            // Get User by email 
            User user = userService.GetUserByEmail(email);

            quiz.UserID = user.UserId;

            quizzContext.Quizzes.Add(quiz);
            quizzContext.SaveChanges();
        }

        public void UpdateQuiz(Quiz quiz)
        {
            // Implement logic to update quiz information in the database
            var existingQuiz = quizzContext.Quizzes.Find(quiz.QuizID);
            if (existingQuiz != null)
            {
                // Update the existing quiz with the values from the provided quiz parameter
                existingQuiz.Title = quiz.Title;
                quizzContext.SaveChanges(); // Save changes to the database
            }
            else
            {
                throw new ArgumentException("Quiz not found", nameof(quiz));
            }

        }

        public void DeleteQuiz(int quizId)
        {
            // Implement logic to delete a quiz from the database
            throw new NotImplementedException();
        }
    }
}
