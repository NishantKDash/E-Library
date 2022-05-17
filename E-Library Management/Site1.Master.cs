using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace E_Library_Management
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty((string)Session["role"]))
                {
                    LinkButton1.Visible = true;  // login   
                    LinkButton2.Visible = true;  // signup

                    LinkButton3.Visible = false;  // logout 
                    LinkButton7.Visible = false;  //Hello user


                    LinkButton6.Visible = true;
                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;
                }
                else if(Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false;  // login   
                    LinkButton2.Visible = false;  // signup

                    LinkButton3.Visible = true;  // logout 
                    LinkButton7.Visible = true;  //Hello user
                    LinkButton7.Text = "Hello " + Session["username"].ToString();


                    LinkButton6.Visible = true;
                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;
                }
                else if(Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;  // login   
                    LinkButton2.Visible = false;  // signup

                    LinkButton3.Visible = true;  // logout 
                    LinkButton7.Visible = true;  //Hello user
                    LinkButton7.Text = "Hello " + Session["username"].ToString();


                    LinkButton6.Visible = false;
                    LinkButton11.Visible = true;
                    LinkButton12.Visible = true;
                    LinkButton8.Visible = true;
                    LinkButton9.Visible = true;
                    LinkButton10.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Failed" + ex.ToString());
                Response.Write("<script>alert('" + ex.Message + "');</script>");
               
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Write("<script language='javascript'>window.alert('Successfully Logged Out');window.location='yourpage.aspx';</script>");
            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}