using QuizzCraftService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraftService.Services
{
    public class QuizService : IQuizService
    {

        // Get Access Of TeacherServices 
        TeacherService teacherService = new TeacherService();

        public QuizService()
        {
            teacherService = new TeacherService();
        }
        public string AddQuiz(Quiz quiz, string email)
        {

            try
            {
                using (var qc = new QuizzDbContext())
                {
                    // email : From Session 

                    // Get User by email 
                    Teacher teacher = teacherService.GetTeacherByEmail(email);

                    quiz.TeacherId = teacher.TeacherId;

                    qc.Quizzes.Add(quiz);
                    qc.SaveChanges();


                    teacher.CreatedQuizzes++;

                    qc.Entry(teacher).State = EntityState.Modified;
                    qc.SaveChanges();

                    return "added";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        public void DeleteQuiz(int quizId)
        {
            using (var qc = new QuizzDbContext())
            {
                // Find the quiz by its ID
                var quiz = qc.Quizzes.Find(quizId);

                if (quiz != null)
                {
                    // Get the teacher associated with the quiz
                    var teacherId = quiz.TeacherId;

                    Teacher teacher = teacherService.GetTeacherById(teacherId);

                    // Decrement the number of created quizzes for the teacher

                    if(teacher.CreatedQuizzes > 0)
                        teacher.CreatedQuizzes--;

                    // Remove the quiz from the DbSet
                    qc.Quizzes.Remove(quiz);

                    // Save changes to the database
                    qc.SaveChanges();

                    // Update the teacher's data in the database
                    qc.Entry(teacher).State = EntityState.Modified;
                    qc.SaveChanges();
                }
                else
                {
                    // Quiz with the specified ID not found
                    // You can handle this case based on your application's requirements
                    // For example, throw an exception or log a message
                    throw new Exception("Quiz not found.");
                }

            }
        }

        public List<Quiz> GetAllQuizzes()
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    return qc.Quizzes.ToList();
        
                }
            }
            catch (Exception ex)
            {
                return new List<Quiz>();
            }

        }

        public List<Quiz> GetMyQuizzes(string email)
        {


            try
            {
                using (var qc = new QuizzDbContext())
                {

                    var teacher = qc.Teachers.FirstOrDefault(t => t.Email == email);

                    if (teacher == null)
                    {
                        // Handle case where teacher with specified email doesn't exist
                        return new List<Quiz>();
                    }

                    // Assuming Quizzes is a DbSet<Quiz> property in QuizzDbContext
                    List<Quiz> quizzes = qc.Quizzes.Where(q => q.TeacherId == teacher.TeacherId).ToList();

                    return quizzes;
                }
            }
            catch (Exception ex)
            {
                return new List<Quiz>();
            }
            
        }

        public Quiz GetQuiz(int quizId)
        {
            using (var qc = new QuizzDbContext())
            {
                // Find the quiz by its ID
                var quiz = qc.Quizzes.Find(quizId);

                if (quiz != null)
                {
                    return quiz;
                }
                else
                {
                    // Quiz with the specified ID not found
                    throw new Exception("Quiz not found.");
                }

            }
        }

        public string UpdateQuiz(Quiz quiz)
        {
            try
            {
                using (var qc = new QuizzDbContext())
                {
                    // Find the existing quiz in the database
                    var existingQuiz = qc.Quizzes.Find(quiz.QuizId);

                    if (existingQuiz != null)
                    {
                        // Update the properties of the existing quiz
                        existingQuiz.Title = quiz.Title;
                        // Update other properties as needed

                        // Save changes to the database
                        qc.SaveChanges();

                        return existingQuiz.Title + " Updated.";
                    }
                    else
                    {
                        return "Quiz Not Found";  
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
