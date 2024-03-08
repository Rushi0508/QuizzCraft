using QuizzCraftClient.QuestionServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class UpdateQuestion : System.Web.UI.Page
    {

        protected int quizId { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                QuestionServiceReference.QestionServiceClient questionServiceClient = new QuestionServiceReference.QestionServiceClient();

                int quesid = int.Parse(Request.QueryString["quesid"]);

                Question question = questionServiceClient.GetQuestionById(quesid);

                txtCorrectAnswer.Text = question.CorrectAnswer;
                txtOptionA.Text = question.OptionA;
                txtOptionB.Text = question.OptionB;
                txtOptionC.Text = question.OptionC;
                txtOptionD.Text = question.OptionD;
                txtQuestion.Text = question.QuestionText;
                quizId = question.QuizId;
            }
        }

        protected void btnUpdateQuestion_Click(object sender, EventArgs e)
        {

            QuestionServiceReference.QestionServiceClient questionServiceClient = new QuestionServiceReference.QestionServiceClient();

            Question question = new Question();
            int quesid = int.Parse(Request.QueryString["quesid"]);

            question.QuestionID = quesid;
            question.CorrectAnswer = txtCorrectAnswer.Text;
            question.OptionA = txtOptionA.Text;
            question.OptionB = txtOptionB.Text;
            question.OptionC = txtOptionC.Text;
            question.OptionD = txtOptionD.Text;
            question.QuestionText = txtQuestion.Text;
            question.QuizId = quizId;

            questionServiceClient.UpdateQuestion(question);

            Response.Redirect("~/Views/MyQuizzes.aspx");
        }
    }
}