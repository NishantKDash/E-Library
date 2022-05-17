using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Library_Management
{
    public partial class adminlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //Creating the commmand to be fired in the database
                SqlCommand cmd = new SqlCommand("  select * from admin_login_tbl where  username = '" + TextBox1.Text.Trim() + "' and password = '" + TextBox2.Text.Trim() + "'", con);
                //Using an adapter to fire the above query in  DB
                SqlDataReader dr = cmd.ExecuteReader();

                //check the result 

                if (dr.HasRows)
                {
                    Response.Write("<script language='javascript'>window.alert('Successfully Logged In as Admin');window.location='adminlogin.aspx';</script>");
                    while (dr.Read())
                    {


                        Session["username"] = dr.GetValue(0).ToString();
                        Session["fullname"] = dr.GetValue(2).ToString();
                        Session["role"] = "admin";
                        //Session["status"] = dr.GetValue(10).ToString();
                    }
                    Response.Redirect("homepage.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alert()", true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}