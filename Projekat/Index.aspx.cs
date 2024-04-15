using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekat
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=KorisnickiPodaci;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(cs);

            string adm = Session["Provera"].ToString();

            if (adm == "admin@gmail.com")
            {
                using(con)
                {
                    con.Open();
                    Button1.Visible = true;
                    TextBox1.Visible= true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    string query = "SELECT * FROM Auto";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    con.Close();
                }
               
            }
            else if (adm != "admin@gmail.com")
            {
                using(con)
                {
                    con.Open() ;
                    string query = "SELECT * FROM Automobili";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    con.Close();
                }
            }

            else if(adm == "")
            {
                Response.Redirect("~/Register");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dJ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            using (con)
            {
                string query = "INSET INTO Auto VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                string query1 = "SELECT * FROM Auto";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}