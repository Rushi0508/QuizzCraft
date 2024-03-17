using QuizzCraftClient.TeacherServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class TeacherSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string role = Session["role"]?.ToString();
            if (role == "teacher" || role == "student")
            {
                Response.Redirect("~/Views/Index.aspx");
            }

            lblSignUpSuccessfull.Text = "";
            lblSignUpError.Text = "";
            lblConfirmPassword.Text = "";
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string name = tbName.Text;
            string cpassword = tbConfirmPassword.Text;

            if(cpassword != password)
            {
                lblConfirmPassword.Text = "Confirm Password Not match with Password.";
                return;
            }

            TeacherServiceReference.TeacherServiceClient tc = new TeacherServiceReference.TeacherServiceClient();

            // If Teacher with same email id exsist or Not 
            if(tc.GetTeacherByEmail(email) != null)
            {
                lblSignUpError.Text = "Teacher with " + email + " already exist.";
                return ;
            }
            
            Teacher teacher = new Teacher();
            teacher.Email = email;
            teacher.Password = password;
            teacher.Name = name;
            teacher.CreatedQuizzes = 0;

            string s = tc.AddTeacher(teacher);

            s += " Your Account is created. Now You can SignIn.";

            lblSignUpSuccessfull.Text = s;
        }
    }
}