using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolSystem.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace SchoolSystem
{
    public partial class testSearchStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                string mainconn = ConfigurationManager.ConnectionStrings["DBConnect"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand();
                if(byId_rdb.Checked)
                {
                    //string sqlquery = "select * from [dbo].[Students] where Id like '%'+@Id+'%'";
                    //sqlcomm.CommandText = sqlquery;
                    //sqlcomm.Connection = sqlconn;
                    //sqlcomm.Parameters.AddWithValue("Id", QueryBox);
                    //DataTable dt = new DataTable();
                    //SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                    //sda.Fill(dt);
                    //StudentGridView.DataSource = dt;
                    //StudentGridView.DataBind();

                }
                else if (byFname_rdb.Checked)
                {

                }
                else if (byLname_rdb.Checked)
                {

                }

            }
        }

    }
}