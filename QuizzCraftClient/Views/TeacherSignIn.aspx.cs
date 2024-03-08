using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class TeacherSignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

 
        protected void SignInButton_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            TeacherServiceReference.TeacherServiceClient tc = new TeacherServiceReference.TeacherServiceClient();
            // If Teacher with same email id exsist or Not 
            if (tc.GetTeacherByEmail(email) == null)
            {
                lblSignInError.Text = "Teacher with " + email + " not exist.";
                return;
            }

            if (tc.VerifyTeacher(email, password) == null)
            {
                lblSignInError.Text = "Please Check your credentials.";
                return;
            }

            Session["email"] = email;
            Session["role"] = "teacher";

            Response.Redirect("~/Views/MyQuizzes.aspx");

        }
    }
}