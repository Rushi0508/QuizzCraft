using QuizzCraftClient.QuestionServiceReference;
using QuizzCraftClient.QuizServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class QuizQuestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string role = Session["role"]?.ToString();
            if (role != "teacher")
            {
                Response.Redirect("~/Views/Index.aspx");
            }

            if (!IsPostBack)
            {
                QuestionServiceReference.QuestionServiceClient questionServiceClient = new QuestionServiceReference.QuestionServiceClient();

                QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();


                int qid = int.Parse(Request.QueryString["qid"]);

                Quiz quiz = quizServiceClient.GetQuiz(qid);

                string quizTitle = quiz.Title;
                string quizSubject = quiz.Subject;
                qtitle.Text = quizTitle;
                qsubject.Text = quizSubject;

                ICollection<Question> questionList = questionServiceClient.GetAllQuestionsByQuiz(qid);

                

                // Bind the questionList to the GridView control
                GridViewQuestions.DataSource = questionList;
                GridViewQuestions.DataBind();
            }
        }

        protected void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            QuestionServiceReference.QuestionServiceClient questionServiceClient = new QuestionServiceReference.QuestionServiceClient();

            Button btnUpdate = (Button)sender;
            int questionId = int.Parse(btnUpdate.CommandArgument);

            
            Response.Redirect("~/Views/UpdateQuestion.aspx?quesid=" + questionId);

        }
        protected void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            QuestionServiceReference.QuestionServiceClient questionServiceClient = new QuestionServiceReference.QuestionServiceClient();

            Button btnDelete = (Button)sender;
            int questionId = int.Parse(btnDelete.CommandArgument);

            questionServiceClient.DeleteQuestion(questionId);


            // Decrease Number of Questions from Quiz 
            QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();

            int qid = int.Parse(Request.QueryString["qid"]);

            Quiz quiz = quizServiceClient.GetQuiz(qid);

            quiz.NumberOfQuestions = quiz.NumberOfQuestions - 1;

            quizServiceClient.UpdateQuiz(quiz);

            Response.Redirect("~/Views/MyQuizzes.aspx"); 
        }
    }
}