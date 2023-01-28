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
    public partial class Automobil : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                try
                {
                    con.Open();

                    string upit = "select imeUsluge from vrstaUsluge";
                    SqlCommand cmd = new SqlCommand(upit, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DropDownList1.Items.Add(reader[0].ToString());
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != "" && TextBox2.Text != "")
            {
                try
                {
                    con.Open();

                    string marka = TextBox1.Text;
                    string model = TextBox2.Text;
                    string imeUsluge = DropDownList1.SelectedItem.Value.ToString();

                    UnesiAutomobil(marka, model, imeUsluge);

                    Response.Redirect("~/Account/Automobil.aspx", false);
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
                Label4.Text = "Polja ne smeju biti prazna.";
            }
        }

        protected void UnesiAutomobil(string marka, string model, string imeUsluge)
        {
            SqlParameter p1 = new SqlParameter();
            SqlParameter p2 = new SqlParameter();
            SqlParameter p3 = new SqlParameter();
            p1.Value = marka;
            p2.Value = model;
            p3.Value = imeUsluge;
            p1.ParameterName = "marka";
            p2.ParameterName = "model";
            p3.ParameterName = "imeUsluge";
            string komanda = "insert into automobil (marka,model,vrstaUsluge) values (@marka, @model, @imeUsluge)";
            SqlCommand cmd = new SqlCommand(komanda, con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.ExecuteNonQuery();
        }
    }
}