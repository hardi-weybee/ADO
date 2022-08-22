using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webFormDemo
{
    public partial class info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitID_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database = student; integrated security=SSPI");
                string q = "insert into info(Name,Address,Number)values('" +nameID.Text+"','" + addressID.Text + "','" + numberID.Text + "')";
                //SqlCommand sc = new SqlCommand("insert into info(Name, Address, Number) values('nameID.Text', 'addressID.Text', 'numberID.Text'", con);
                SqlCommand sc = new SqlCommand(q, con);
                con.Open();

                sc.ExecuteNonQuery();

                text.Text = "Information ....";
                SqlCommand scc = new SqlCommand("select top 1 * from info", con);
                SqlDataReader sdr = scc.ExecuteReader();

                sdr.Read();
                    Label1.Text = "Name"; Label4.Text = sdr["Name"].ToString();
                    Label2.Text = "Address"; Label5.Text = sdr["Address"].ToString();
                    Label3.Text = "Phone Number"; Label6.Text = sdr["Number"].ToString();
                
            } catch(Exception a)
            {
                text.Text = a.Message;
            } finally
            {
                con.Close();
            }           
        }
    }
}