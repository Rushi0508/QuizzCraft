using QuizzCraftClient.QuizServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class AddQuiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateQuizButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string subject = SubjectTextBox.Text;

            string email = Session["email"].ToString();

            QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();

            Quiz q = new Quiz();
            q.Title = title;
            q.Subject = subject;
            q.CreatedAt = DateTime.Now;
           

            string s = quizServiceClient.AddQuiz(q, email);

            Response.Write(s);

        }
    }
}