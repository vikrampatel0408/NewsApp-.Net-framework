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
    public partial class Home : System.Web.UI.Page
    {
        public class News
        {
            private int news_id;
            public int News_id
            {
                get { return this.news_id;  }
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
            if (HttpContext.Current.Session["user"] == null)
            {
                
                    Response.Redirect("Login.aspx");
                
            }
            
                con.Open();
                string getAllNews = "Select * from [news] ";
                SqlCommand getCommand = new SqlCommand(getAllNews, con);
                SqlDataReader read = getCommand.ExecuteReader();

                List<News> newsList = new List<News>();

                while (read.Read())
                {
                    News news = new News();


                    news.News_id = Convert.ToInt32(read["news_id"]);
                    news.News_title = read["news_title"].ToString();
                    news.News_subtitle = read["news_subtitle"].ToString();
                    news.News_content = read["news_content"].ToString();
                    news.Imageurl = read["image_url"].ToString();
                    news.User_id = Convert.ToInt32(read["user_id"]);

                    newsList.Add(news);
                }
                read.Close();
                con.Close();
                if (!IsPostBack)
                {

                    NewsRepeater.DataSource = newsList;
                    NewsRepeater.DataBind();
                }
            
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNews.aspx");
        }
    }
}