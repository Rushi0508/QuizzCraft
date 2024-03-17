using QuizzCraftClient.TeacherServiceReference;
using QuizzCraftClient.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class QuizzCraft : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                try
                {
                    if (Session["role"]?.ToString() == "")
                    {

                        signin.Visible = true;
                        signup.Visible = true;


                        logout.Visible = false;
                        addquiz.Visible = false;
                        quizzes.Visible = false;

                        NoOfQuizzes.Visible = false;
                        Email.Visible = false;

                        /*                  
                           NoOfQuizzes.Visible = true;
                           profile.Visible = false;
                           voting.Visible = false;*/

                    }
                    else if (Session["role"]?.ToString() == "teacher")
                    {
                        TeacherServiceReference.TeacherServiceClient teacherServiceClient = new TeacherServiceReference.TeacherServiceClient();
                        string email = Session["Email"].ToString();

                        Teacher teacher = teacherServiceClient.GetTeacherByEmail(email); 


                        signin.Visible = false;
                        signup.Visible = false;
                        addquiz.Visible = true;
                        quizzes.Visible = true;

                        Q.Visible = true;
                        NoOfQuizzes.Visible = true;
                        NoOfQuizzes.Text = teacher.CreatedQuizzes.ToString();
                        Email.Visible = true;
                        Email.Text = email;


                        logout.Visible = true;
                        /*
                            addparty.Visible = true;
                            voting.Visible = false;*/

                    }
                    else if (Session["role"]?.ToString() == "student")
                    {
                        UserServiceReference.UserServiceClient userServiceClient = new UserServiceReference.UserServiceClient();
                        string email = Session["Email"].ToString();

                        User user = userServiceClient.GetUserByEmail(email);


                        signin.Visible = false;
                        signup.Visible = false;
                        addquiz.Visible = false;
                        quizzes.Visible = false;

                        logout.Visible = true;

                        P.Visible = true;
                        Points.Visible = true;
                        Points.Text = user.Points.ToString();
                        Email.Visible = true;
                        Email.Text = email;

                        /*                  
                                            profile.Visible = true;
                                            voting.Visible = true;*/
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["role"] = "";
            Session["email"] = "";

            signin.Visible = true;
            signup.Visible = true;
            logout.Visible = false;

            P.Visible = false;
            Q.Visible = false;

            Response.Redirect("~/Views/Index.aspx");
        }
    }
}