using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class UserSignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string role = Session["role"]?.ToString();
            if (role == "teacher" || role == "student")
            {
                Response.Redirect("~/Views/Index.aspx");
            }
        }

        protected void SignInButton_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            UserServiceReference.UserServiceClient userServiceClient = new UserServiceReference.UserServiceClient();

            // If Teacher with same email id exsist or Not 
            if (userServiceClient.GetUserByEmail(email) == null)
            {
                lblSignInError.Text = "Student with " + email + " not exist.";
                return;
            }

            if (userServiceClient.VerifyUser(email, password) == null)
            {
                lblSignInError.Text = "Please Check your credentials.";
                return;
            }

            Session["email"] = email;
            Session["role"] = "student";

            Response.Redirect("~/Views/Index.aspx");

        }
    }
}