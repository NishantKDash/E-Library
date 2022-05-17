using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace E_Library_Management
{
    public partial class userlogin : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("  select * from member_master_tbl where  member_id = '"+TextBox1.Text.Trim() +"' and password = '"+TextBox2.Text.Trim() +"'", con); 
                //Using an adapter to fire the above query in  DB
                SqlDataReader dr = cmd.ExecuteReader();

                //check the result 
              
                if(dr.HasRows)
                {
                    

                    while (dr.Read())
                    {
                        Response.Write("<script language='javascript'>window.alert('Successfully logged in');window.location='userlogin.aspx';</script>");

                        Session["username"] = dr.GetValue(8).ToString();
                        Session["fullname"] = dr.GetValue(0).ToString();
                        Session["role"] = "user";
                        Session["status"] = dr.GetValue(10).ToString();
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
                MessageBox.Show("SQL Failed" + ex.ToString());
                Response.Write("<script>alert('"+ex.Message +"');</script>");
            }


            //Response.Write("<script>alert('Testing');</script>");
        }
    }
}