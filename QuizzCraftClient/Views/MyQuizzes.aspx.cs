using QuizzCraftClient.QuizServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class MyQuizzes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();

            string email = Session["email"]?.ToString();

            if (!IsPostBack)
            {

                ICollection<Quiz> quizList = quizServiceClient.GetMyQuizzes(email);

                // Bind the quiz list to the GridView
                GridViewQuizzes.DataSource = quizList;
                GridViewQuizzes.DataBind();

            }

        }

        protected void btnAddQuestion_Click(object sender, EventArgs e)
        {
            Button btnAdd = (Button)sender;
            int qid = int.Parse(btnAdd.CommandArgument);

            Response.Redirect("~/Views/AddQuestion.aspx?qid=" + qid);
        }
        protected void btnShowQuestion_Click(object sender, EventArgs e)
        {
            Button btnAttempt = (Button)sender;
            int qid = int.Parse(btnAttempt.CommandArgument);

            Response.Redirect("~/Views/QuizQuestions.aspx?qid=" + qid);
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();

            Button btnAttempt = (Button)sender;
            int t = int.Parse(btnAttempt.CommandArgument);
            
            Response.Redirect("~/Views/UpdateQuiz.aspx?qid=" + t); 
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient(); 
            Button btnAttempt = (Button)sender;
            int t =  int.Parse(btnAttempt.CommandArgument);
            
            quizServiceClient.DeleteQuiz(t);

            Response.Redirect("~/Views/MyQuizzes.aspx");
        }

    }
}