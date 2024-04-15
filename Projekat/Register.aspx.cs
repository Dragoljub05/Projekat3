using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekat
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Provera"] = "";
        }

   
        protected void Registerdugme_Click(object sender, EventArgs e)
        {
            if(Page.IsValid) { 
            string cs= "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dJ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection con = new SqlConnection(cs))
                {
                   string req = TextBox3.Text;
                    if (TextBox3.Text == TextBox4.Text && req.Length > 5)
                    {
                        string query = "INSERT INTO Korisnici VALUES ('"+TextBox1.Text+ "','"+TextBox2.Text+"','"+TextBox3.Text+"')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        try
                        {
                            con.Open();
                            int uspeh = cmd.ExecuteNonQuery();
                            if (uspeh > 0)
                            {

                                ErrorLabel.Text = "Uspesno prijavljeni!";
                                Response.Redirect("~/Login.aspx");
    
                            }
                            else
                            {

                                ErrorLabel.Text = "Nije uspelo!";

                            }

                        }

                        catch (Exception ex)
                        {
                            
                            ErrorLabel.Text = ex.ToString();

                        }
                    }
                    else
                    {
                        ErrorLabel.Text = "Sifre se ne poklapaju!";
                        return;
                    }
                }
            }
        }

       
    }
}