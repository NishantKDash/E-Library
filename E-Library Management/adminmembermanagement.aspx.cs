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
    public partial class adminmembermanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //get
        protected void LinkButton4_Click1(object sender, EventArgs e)
        {
            if (checkIfMemberExists())
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertf()", true);
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    //Creating the commmand to be fired in the database
                    SqlCommand cmd = new SqlCommand("select * from member_master_tbl where  member_id = '" + TextBox1.Text.Trim() + "'", con);
                    //Using an adapter to fire the above query in  DB
                    SqlDataReader dr = cmd.ExecuteReader();

                    //check the result 


                    while (dr.Read())
                    {


                        TextBox2.Text = dr.GetValue(0).ToString();
                        TextBox7.Text = dr.GetValue(10).ToString();
                        TextBox8.Text = dr.GetValue(1).ToString();
                        TextBox3.Text = dr.GetValue(2).ToString();
                        TextBox4.Text = dr.GetValue(3).ToString();
                        TextBox9.Text = dr.GetValue(4).ToString();
                        TextBox10.Text = dr.GetValue(5).ToString();
                        TextBox11.Text = dr.GetValue(6).ToString();
                        TextBox6.Text = dr.GetValue(7).ToString();



                    }






                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL Failed" + ex.ToString());
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertn2()", true);
            }
        }
        //delete
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteMemberByID();
        }

        protected bool checkIfMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("SELECT * from member_master_tbl where member_id='" + TextBox1.Text.Trim() + "';", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);



                if (dt.Rows.Count >= 1)
                {

                    return true;

                }
                else
                {


                    return false;
                }
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void deleteMemberByID()
        {
            if (checkIfMemberExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from member_master_tbl WHERE member_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertd()", true);
                    clearForm();
                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertn2()", true);
            }
        }

        protected void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox6.Text = "";
        }


        void updateMemberStatusByID(string status)
        {
            if (checkIfMemberExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    SqlCommand cmd = new SqlCommand("UPDATE member_master_tbl SET account_status='" + status + "' WHERE member_id='" + TextBox1.Text.Trim() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();//data is refreshed on grid view 
                    ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertu()", true);


                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertn2()", true);
            }

        }
        //activate
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("active");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("pending");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("deactive");
        }
    }
}