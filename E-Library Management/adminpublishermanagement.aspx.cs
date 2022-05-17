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
    public partial class adminpublishermanagement : System.Web.UI.Page
    {

        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        //page load
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }


        //add
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfPublisherExists())
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertn()", true);
            }
            else
            {
                addPublisher();
            }

        }


        //update
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfPublisherExists())
            {
                updatePublisher();

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertn2()", true);
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfPublisherExists())
            {
                deletePublisher();

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertn2()", true);
            }

        }

        //go
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkIfPublisherExists())
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
                    SqlCommand cmd = new SqlCommand("select * from publisher_master_tbl where  publisher_id = '" + TextBox1.Text.Trim() + "'", con);
                    //Using an adapter to fire the above query in  DB
                    SqlDataReader dr = cmd.ExecuteReader();

                    //check the result 


                    while (dr.Read())
                    {


                        TextBox2.Text = dr.GetValue(1).ToString();


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

        protected bool checkIfPublisherExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("SELECT * from publisher_master_tbl where publisher_id='" + TextBox1.Text.Trim() + "';", con);

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

        protected void addPublisher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO publisher_master_tbl(publisher_id,publisher_name) values(@publisher_id,@publisher_name)", con);
                cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                clearForm();
                GridView1.DataBind();

                ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alert()", true);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void updatePublisher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE publisher_master_tbl SET publisher_name=@publisher_name WHERE publisher_id='" + TextBox1.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "alert_text", "alertu()", true);
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void deletePublisher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Delete publisher_master_tbl WHERE publisher_id='" + TextBox1.Text.Trim() + "'", con);



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

        protected void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}