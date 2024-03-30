using Microsoft.SqlServer.Server;
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
    public partial class AddQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string role = Session["role"]?.ToString();
            if (role != "teacher")
            {
                Response.Redirect("~/Views/Index.aspx");
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int qid = int.Parse(Request.QueryString["qid"]);

            string questionText = txtQuestion.Text;
            string a = txtOptionA.Text;
            string b = txtOptionB.Text;
            string c = txtOptionC.Text;
            string d = txtOptionD.Text;
            string ans = CorrectAnswer.Text;

            Question question = new Question();
            question.QuestionText = questionText;
            question.OptionA = a; 
            question.OptionB = b;
            question.OptionC = c;
            question.OptionD = d;
            question.QuizId = qid;
            question.CorrectAnswer = ans;

            QuestionServiceReference.QuestionServiceClient questionServiceClient = new QuestionServiceReference.QuestionServiceClient();

            questionServiceClient.AddQuestion(question);


            // Increament Number of Questions in Quiz 
            QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();

            Quiz quiz = quizServiceClient.GetQuiz(qid);

            quiz.NumberOfQuestions = quiz.NumberOfQuestions + 1;

            quizServiceClient.UpdateQuiz(quiz);


            lblCreatedSuccessfull.Text = "Question Added Successfully.";

        }
    }
}