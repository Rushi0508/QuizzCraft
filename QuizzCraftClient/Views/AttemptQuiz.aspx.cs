using QuizzCraftClient.QuestionServiceReference;
using QuizzCraftClient.QuizServiceReference;
using QuizzCraftClient.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class AttemptQuiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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



                string userRole = Session["role"]?.ToString();

                if(userRole == "student")
                {
                    btnSubmit.Visible = true;
                }

                ICollection<Question> questionList = questionServiceClient.GetAllQuestionsByQuiz(qid);

                // Bind the questionList to the GridView control
                GridViewQuestions.DataSource = questionList;
                GridViewQuestions.DataBind();
            }
        }

        protected void btnSubmitQuiz_Click(object sender, EventArgs e)
        {
            char ans;
            List<char> selectedOptions = new List<char>();
            QuestionServiceReference.QuestionServiceClient questionServiceClient = new QuestionServiceReference.QuestionServiceClient();
            UserServiceReference.UserServiceClient userServiceClient = new UserServiceReference.UserServiceClient();


            foreach (GridViewRow row in GridViewQuestions.Rows)
            {
                RadioButton optionARadioButton = row.FindControl("RadioButtonOptionA") as RadioButton;
                RadioButton optionBRadioButton = row.FindControl("RadioButtonOptionB") as RadioButton;
                RadioButton optionCRadioButton = row.FindControl("RadioButtonOptionC") as RadioButton;
                RadioButton optionDRadioButton = row.FindControl("RadioButtonOptionD") as RadioButton;

                ans = ' ';

                if (optionARadioButton != null && optionARadioButton.Checked)
                {
                    ans = 'A';
                }
                else if (optionBRadioButton != null && optionBRadioButton.Checked)
                {   
                    ans = 'B';
                }
                else if (optionCRadioButton != null && optionCRadioButton.Checked)
                {
                    ans = 'C';
                }
                else if (optionDRadioButton != null && optionDRadioButton.Checked)
                {
                    ans = 'D';
                }
                selectedOptions.Add(ans);

            }

            int qid = int.Parse(Request.QueryString["qid"]);

            ICollection<Question> questionList = questionServiceClient.GetAllQuestionsByQuiz(qid);

            int i = 0;
            int points = 0;
            foreach (Question question in questionList)
            {
                if (question.CorrectAnswer == selectedOptions[i].ToString())
                    points++;

                i++;
            }

            string email = Session["email"].ToString();
            User user = userServiceClient.GetUserByEmail(email);


            user.Points = points;
            user.AttemptedQuizzes = 1;

            string u = userServiceClient.UpdateUser(user);

            // Update Attendees in Quiz 
            QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();

            Quiz quiz = quizServiceClient.GetQuiz(qid);

            quiz.Attendees = quiz.Attendees + 1;

            quizServiceClient.UpdateQuiz(quiz);
            
            Response.Redirect("~/Views/AttemptQuiz.aspx?qid=" + qid);
        }
    }
}