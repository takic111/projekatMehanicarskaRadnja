using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MehanicarskaRadnja.Admin
{
    public partial class PregledPodataka : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                UcitajAutomobile();
                UcitajCenovnik();
                UcitajRadnike();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        protected void UcitajAutomobile()
        {
            string komanda = "select * from automobil";
            SqlDataAdapter ad = new SqlDataAdapter(komanda, con);
            DataTable t = new DataTable();
            ad.Fill(t);
            GridView1.DataSource = t;
            GridView1.DataBind();
        }
        
        protected void UcitajCenovnik()
        {
            string komanda = "select * from vrstaUsluge";
            SqlDataAdapter ad = new SqlDataAdapter(komanda, con);
            DataTable t = new DataTable();
            ad.Fill(t);
            GridView2.DataSource = t;
            GridView2.DataBind();
        }

        protected void UcitajRadnike()
        {
            string komanda = "select * from radnik";
            SqlDataAdapter ad = new SqlDataAdapter(komanda, con);
            DataTable t = new DataTable();
            ad.Fill(t);
            GridView3.DataSource = t;
            GridView3.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow != null)
            {
                try
                {
                    con.Open();
                    string komanda = "delete from automobil where Id = " + GridView1.SelectedRow.Cells[1].Text;
                    SqlCommand cmd = new SqlCommand(komanda, con);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("~/Admin/PregledPodataka.aspx", false);
                }
                catch(Exception ex ) 
                {
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
                Label1.Text = "Niste izabrali automobil.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (GridView3.SelectedRow != null)
            {
                try
                {
                    con.Open();
                    string komanda = "delete from radnik where Id = " + GridView3.SelectedRow.Cells[1].Text;
                    SqlCommand cmd = new SqlCommand(komanda, con);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("~/Admin/PregledPodataka.aspx", false);
                }
                catch (Exception ex) 
                {
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
                Label2.Text = "Niste izabrali radnika.";
            }
        }
    }
}