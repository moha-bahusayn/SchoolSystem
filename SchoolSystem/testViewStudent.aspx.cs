using SchoolSystem.Models;
using System;
using System.Data;
using System.Linq;

namespace SchoolSystem
{
    public partial class testViewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ViewBtn_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Student std = db.Students.Find(2);

                DataTable dt = new DataTable();
                dt.Clear();

                dt.Columns.Add("ID");
                dt.Columns.Add("First Name");
                dt.Columns.Add("Last Name");

                DataRow dr = dt.NewRow();
                dr[0] = std.Id;
                dr[1] = std.FirstName;
                dr[2] = std.LastName;
                dt.Rows.Add(dr);

                StudentGridView.DataSource = dt;
                StudentGridView.DataBind();
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Student std = db.Students.Find(2);
                db.Students.Remove(std);
                db.SaveChanges();
                DataTable dt = new DataTable();
                dt.Clear();

                dt.Columns.Add("ID");
                dt.Columns.Add("First Name");
                dt.Columns.Add("Last Name");

                DataRow dr = dt.NewRow();
                dr[0] = std.Id;
                dr[1] = std.FirstName;
                dr[2] = std.LastName;
                dt.Rows.Add(dr);

                StudentGridView.DataSource = dt;
                StudentGridView.DataBind();
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                var std = db.Students.First<Student>();
                std.FirstName = "Michael";
                db.SaveChanges();

                DataTable dt = new DataTable();
                dt.Clear();

                dt.Columns.Add("ID");
                dt.Columns.Add("First Name");
                dt.Columns.Add("Last Name");

                DataRow dr = dt.NewRow();
                dr[0] = std.Id;
                dr[1] = std.FirstName;
                dr[2] = std.LastName;
                dt.Rows.Add(dr);

                StudentGridView.DataSource = dt;
                StudentGridView.DataBind();
            }
        }
    }
}