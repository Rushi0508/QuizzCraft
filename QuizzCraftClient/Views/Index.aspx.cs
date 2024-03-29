﻿    using QuizzCraftClient.QuizServiceReference;
using QuizzCraftClient.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            QuizServiceReference.QuizServiceClient quizServiceClient = new QuizServiceReference.QuizServiceClient();

            UserServiceReference.UserServiceClient userServiceClient = new UserServiceReference.UserServiceClient();    
         
            if (!IsPostBack)
            {

                ICollection<Quiz> quizList = quizServiceClient.GetAllQuizzes();

                // Bind the quiz list to the GridView
                GridViewQuizzes.DataSource = quizList;
                GridViewQuizzes.DataBind();

                

                ICollection<User> topperList = userServiceClient.GetAllUsers();

                GridViewStudents.DataSource = topperList;
                GridViewStudents.DataBind();
            }
        }
        
        protected void btnAttemptQuiz_Click(object sender, EventArgs e)
        {

            Button btnAttempt = (Button)sender;
            int qid = int.Parse(btnAttempt.CommandArgument);
                
            Response.Redirect("~/Views/AttemptQuiz.aspx?qid=" + qid);
        }


    }
}