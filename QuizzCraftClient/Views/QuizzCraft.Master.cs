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

/*
            try
            {
                if (Session["role"].Equals(""))
                {

                    signin.Visible = true;
                    signup.Visible = true;
                    addquestion.Visible = false;
                    
                    logout.Visible = false;

*//*
                    profile.Visible = false;
                    voting.Visible = false;*//*
                }
                else if (Session["role"].Equals("teacher"))
                {


                    signin.Visible = false;
                    signup.Visible = false;
                    addquestion.Visible = true;
                    
                    logout.Visible = true;
                *//*
                    addparty.Visible = true;
                    voting.Visible = false;*//*

                }
                else if (Session["role"].Equals("user"))
                {

                    signin.Visible = false;
                    signup.Visible = false;
                    addquestion.Visible = false;

                    logout.Visible = true;

*//*
                    profile.Visible = true;
                    voting.Visible = true;*//*
                }
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.Message);
            }

            */
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["role"] = "";
            Session["email"] = "";

            signin.Visible = true;
            signup.Visible = true;

            logout.Visible = false;
            

            
            Response.Redirect("~/Views/Index.aspx");
        }
    }
}