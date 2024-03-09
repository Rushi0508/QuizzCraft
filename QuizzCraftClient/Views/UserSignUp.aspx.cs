using QuizzCraftClient.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class UserSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblSignUpSuccessfull.Text = "";
            lblSignUpError.Text = "";
            lblConfirmPassword.Text = "";
        }

        
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string cpassword = tbConfirmPassword.Text;

            UserServiceReference.UserServiceClient uc = new UserServiceReference.UserServiceClient("NetTcpBinding_IUserService");
            User u = new User();
            u.Email = email;
            u.Password = password;
            u.Name = name;
            u.Points = 0;
            u.AttemptedQuizzes = 0;

            if (cpassword != password)
            {
                lblConfirmPassword.Text = "Confirm Password Not match with Password.";
                return;
            }

            
            // If Teacher with same email id exsist or Not 
            if (uc.GetUserByEmail(email) != null)
            {
                lblSignUpError.Text = "User with " + email + " already exist.";
                return;
            }

            string s = uc.AddUser(u);


            s += " Your Account is created. Now You can SignIn.";

            lblSignUpSuccessfull.Text = s;
        }
    }
}