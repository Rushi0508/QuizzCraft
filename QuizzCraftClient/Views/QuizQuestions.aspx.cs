using QuizzCraftClient.QuestionServiceReference;
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
                QuestionServiceReference.QestionServiceClient questionServiceClient = new QuestionServiceReference.QestionServiceClient();

                int qid = int.Parse(Request.QueryString["qid"]);

                ICollection<Question> questionList = questionServiceClient.GetAllQuestionsByQuiz(qid);

                

                // Bind the questionList to the GridView control
                GridViewQuestions.DataSource = questionList;
                GridViewQuestions.DataBind();
            }
        }

        protected void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            QuestionServiceReference.QestionServiceClient questionServiceClient = new QuestionServiceReference.QestionServiceClient();

            Button btnUpdate = (Button)sender;
            int questionId = int.Parse(btnUpdate.CommandArgument);

            
            Response.Redirect("~/Views/UpdateQuestion.aspx?quesid=" + questionId);

        }
        protected void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            QuestionServiceReference.QestionServiceClient questionServiceClient = new QuestionServiceReference.QestionServiceClient();

            Button btnDelete = (Button)sender;
            int questionId = int.Parse(btnDelete.CommandArgument);

            questionServiceClient.DeleteQuestion(questionId);

            Response.Redirect("~/Views/MyQuizzes.aspx"); 
        }
    }
}