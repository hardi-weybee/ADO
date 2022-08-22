using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dataTableForm
{
    public partial class tableForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Rows.Add("1", "Chandler", "chandler@gmail.com");
            table.Rows.Add("2", "Ross", "ross@gmail.com");
            table.Rows.Add("3", "Joey", "joey@gmail.com");
            table.Rows.Add("4", "Phoebe", "phoebe@gmail.com");
            table.Rows.Add("5", "Monica", "monica@gmail.com");
            table.Rows.Add("6", "Rachel", "rachel@gmail.com");

            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}