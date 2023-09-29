using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace NewsApplication
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void regBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string insertUser = "insert into [user] (first_name,last_name,email,password) values (@fname,@lname,@email_id,@pwd) ";
            SqlCommand cmUser = new SqlCommand(insertUser,con);
            cmUser.Parameters.AddWithValue("@fname", firstname.Text.ToString());
            cmUser.Parameters.AddWithValue("@lname", lastname.Text.ToString());
            cmUser.Parameters.AddWithValue("@email_id", email.Text.ToString());
            cmUser.Parameters.AddWithValue("@pwd", password.Text.ToString());
            cmUser.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Login.aspx");
        }
    }
}