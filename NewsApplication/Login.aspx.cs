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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string CheckUser = "Select user_id,email,first_name,last_name from [user] where email=@email and password=@password";
            SqlCommand Checkcmd = new SqlCommand(CheckUser, con);
            Checkcmd.Parameters.AddWithValue("@email", email.Text.ToString());
            Checkcmd.Parameters.AddWithValue("@password", password.Text.ToString());
            SqlDataReader read = Checkcmd.ExecuteReader();
            if (read.Read())
            {
                Session["user_id"] = read.GetValue(0).ToString();
                Session["email"] = read.GetValue(1).ToString();
                Session["first_name"] = read.GetValue(2).ToString();
                Session["last_name"] = read.GetValue(3).ToString();
                Session["user"] = "true";
                con.Close();
                Response.Redirect("Home.aspx");
            }
            else
            {
                errorMsg.Text = "Invalid Email or Password";
                errorMsg.ForeColor = System.Drawing.Color.Red;
                con.Close();
            }
        }
    }
}