using QuizzCraftClient.QuizServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class UpdateQuiz : System.Web.UI.Page
    {

        
        protected int qid { get; set; } = 0;
        protected Quiz quiz { get; set; } = new Quiz();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();
                qid = int.Parse(Request.QueryString["qid"]);

                quiz = quizServiceClient.GetQuiz(qid);

                TitleTextBox.Text = quiz.Title;
                SubjectTextBox.Text = quiz.Subject;
            }
        }

        protected void UpdateQuizButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string subject = SubjectTextBox.Text;
            
            Quiz quizU = new Quiz();
            qid = int.Parse(Request.QueryString["qid"]);
            quizU.QuizId = qid;
            quizU.Title = title;
            quizU.Subject = subject;
            QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();
            
            string ans = quizServiceClient.UpdateQuiz(quizU);


            Response.Redirect("~/Views/MyQuizzes.aspx");
        }
    }
}