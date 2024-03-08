using Microsoft.SqlServer.Server;
using QuizzCraftClient.QuestionServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class AddQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int qid = int.Parse(Request.QueryString["qid"]);

            string questionText = txtQuestion.Text;
            string a = txtOptionA.Text;
            string b = txtOptionB.Text;
            string c = txtOptionC.Text;
            string d = txtOptionD.Text;
            string ans = txtCorrectAnswer.Text;

            Question question = new Question();
            question.QuestionText = questionText;
            question.OptionA = a; 
            question.OptionB = b;
            question.OptionC = c;
            question.OptionD = d;
            question.QuizId = qid;
            question.CorrectAnswer = ans;

            QuestionServiceReference.QestionServiceClient questionServiceClient = new QuestionServiceReference.QestionServiceClient();

            questionServiceClient.AddQuestion(question);

        }
    }
}