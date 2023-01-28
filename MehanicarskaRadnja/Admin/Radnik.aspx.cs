using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MehanicarskaRadnja.Account
{
    public partial class Radnik : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
            {
                try
                {
                    con.Open();
                    string ime = TextBox1.Text;
                    string prezime = TextBox2.Text;
                    int plata = int.Parse(TextBox3.Text);
                    UnesiRadnika(ime, prezime, plata);
                    Response.Redirect("~/Admin/Radnik.aspx", false);
                }
                catch (Exception ex)
                {
                    Label4.Text = "Greska.";
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                Label4.Text = "Polja moraju biti popunjena.";
            }
        }

        protected void UnesiRadnika(string ime, string prezime, int plata)
        {
            SqlParameter p1 = new SqlParameter();
            SqlParameter p2 = new SqlParameter();
            p1.Value = ime + " " + prezime;
            p2.Value = plata;
            p1.ParameterName = "imePrezime";
            p2.ParameterName = "plata";
            string komanda = "insert into radnik(imePrezime, plata) values (@imePrezime, @plata)";
            SqlCommand cmd = new SqlCommand(komanda, con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.ExecuteNonQuery();
        }
    }
}