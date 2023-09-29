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
    public partial class Fullnews : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.Image Image1;

        public class News
            {
                private int news_id;
                public int News_id
                {
                    get { return this.news_id; }
                    set { this.news_id = value; }
                }
                private string news_title;
                public string News_title
                {
                    get { return this.news_title; }
                    set { this.news_title = value; }
                }
                private string news_subtitle;
                public string News_subtitle
                {
                    get { return this.news_subtitle; }
                    set { this.news_subtitle = value; }
                }
                private string news_content;
                public string News_content
                {
                    get { return this.news_content; }
                    set { this.news_content = value; }
                }
                private string imageurl;
                public string Imageurl
                {
                    get { return this.imageurl; }
                    set { this.imageurl = value; }
                }
                private int user_id;
                public int User_id
                {
                    get { return this.user_id; }
                    set { this.user_id = value; }
                }
                
                

            }
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
            protected void Page_Load(object sender, EventArgs e)
            {
            int user_id = 0;
                con.Open();
                string getFullNews = "SELECT * FROM [news] WHERE news_id = @id";
                SqlCommand getCommand = new SqlCommand(getFullNews, con);
                int id = Convert.ToInt32(Request.QueryString["id"]);
                getCommand.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = getCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    News newsItem = new News
                    {
                        News_id = Convert.ToInt32(reader["news_id"]),
                        News_title = reader["news_title"].ToString(),
                        News_subtitle = reader["news_subtitle"].ToString(),
                        News_content = reader["news_content"].ToString(),
                        Imageurl = reader["image_url"].ToString(),
                        User_id = Convert.ToInt32(reader["user_id"])
                    };

                    Image1.ImageUrl = newsItem.Imageurl;
                    LabelTitle.Text = newsItem.News_title;
                    LabelContent.Text = newsItem.News_content;
                    LabelSubtitle.Text = newsItem.News_subtitle;
                    user_id = newsItem.User_id;
                    
                }
            }
            reader.Close();
            string getUser = "select * from [user] where user_id=@user_id";
                    SqlCommand getUsercmd = new SqlCommand(getUser, con);
                    getUsercmd.Parameters.AddWithValue("@user_id", user_id);
                    SqlDataReader userReader = getCommand.ExecuteReader();
                    if (userReader.HasRows)
                    {
                        while (userReader.Read())
                        {
                            user.Text = userReader[1].ToString() + " " + userReader[2].ToString();
                        }
                    }
                    userReader.Close();
                
                
                

                
                con.Close();
            
            



            }

        
    }
    
}