using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzCraftClient.Views
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string role = Session["role"]?.ToString();
            if (role == "teacher" || role == "student")
            {
                Response.Redirect("~/Views/Index.aspx");
            }
        }
    }
}