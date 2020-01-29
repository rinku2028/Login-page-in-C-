using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace login
{
    public partial class Login : System.Web.UI.Page
    {
        String sql = "Data Source=desktop-tb3r1mj;Initial Catalog=access;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection dataconn = new SqlConnection(sql);
            dataconn.Open();
            String str = "select username,password from login where username='" + txtusername.Text + "'and password='" + txtpassword.Text + "' ";
            SqlCommand sqlcommand = new SqlCommand(str, dataconn);
            SqlDataReader reader = sqlcommand.ExecuteReader();
            if(reader.Read()==true)
            {
                lblmessage.Text = "You are successfully logged in!";
                Response.Redirect("welcome.aspx");
            }
            else
            {
                lblmessage.Text="You are not authorized to logged in!";
            }

        }
    }
}