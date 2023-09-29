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
    public partial class AddNews : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            con.Open();
            string insertNews = "insert into [news] (news_title,news_subtitle,news_content,image_url,user_id) values (@title,@subtitle,@content,@image,@user)";
            SqlCommand cmNews = new SqlCommand(insertNews, con);
            cmNews.Parameters.AddWithValue("@title", title.Text.ToString());
            cmNews.Parameters.AddWithValue("@subtitle", Subtitle.Text.ToString());
            cmNews.Parameters.AddWithValue("@content", Content.Text.ToString());
            cmNews.Parameters.AddWithValue("@image", Imageurl.Text.ToString());
            cmNews.Parameters.AddWithValue("@user", HttpContext.Current.Session["user_id"].ToString());
            cmNews.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Home.aspx");

        }
    }
}