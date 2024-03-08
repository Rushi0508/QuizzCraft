using QuizzCraftService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraftService.Services
{
    public class QuestionService : IQestionService
    {
        public string AddQuestion(Question question)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {

                    qc.Questions.Add(question);
                    qc.SaveChanges();

                    return "Question added";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public void DeleteQuestion(int questionId)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    // Find the question by its ID
                    Question questionToDelete = qc.Questions.Find(questionId);

                    if (questionToDelete != null)
                    {
                        // Remove the question from the DbSet and save changes
                        qc.Questions.Remove(questionToDelete);
                        qc.SaveChanges();
                    }
                    else
                    {
                        // Question not found, handle this case
                        throw new Exception($"Question with ID {questionId} not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw; // Rethrow the exception to the caller
            }
        }

        public List<Question> GetAllQuestionsByQuiz(int quizId)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    // Query the database for questions associated with the specified quizId
                    List<Question> questions = qc.Questions.Where(q => q.QuizId == quizId).ToList();

                    return questions;
                }
            }
            catch (Exception ex)
            {
                return new List <Question>();
            }
        }

        public Question GetQuestionById(int questionId)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    // Query the database for questions associated with the specified quizId
                    Question question = qc.Questions.FirstOrDefault(q => q.QuestionID ==  questionId);

                    return question;
                }
            }
            catch (Exception ex)
            {
                return new Question();
            }
        }

        public string UpdateQuestion(Question question)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    // Find the question by its ID
                    Question existingQuestion = qc.Questions.Find(question.QuestionID);

                    if (existingQuestion != null)
                    {
                        // Update the properties of the existing question
                        existingQuestion.QuestionText = question.QuestionText;
                        existingQuestion.CorrectAnswer = question.CorrectAnswer;
                        existingQuestion.OptionA = question.OptionA;
                        existingQuestion.OptionB = question.OptionB;
                        existingQuestion.OptionC = question.OptionC;
                        existingQuestion.OptionD = question.OptionD;

                        // Save changes to the database
                        qc.SaveChanges();

                        return "Question updated successfully.";
                    }
                    else
                    {
                        // Question not found, return an error message
                        return "Question not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw; // Rethrow the exception to the caller
            }

        }
    }
}
