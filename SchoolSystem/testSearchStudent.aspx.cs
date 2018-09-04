using SchoolSystem.Models;
using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

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
                if (byId_rdb.Checked)
                {
                    int id = Int32.Parse(QueryBox.Text);

                    var std = db.Students.Find(id);

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
                else if (byFname_rdb.Checked)
                {
                    string firstName = QueryBox.Text;
                    var studentList = db.Students.Where(s => s.FirstName.Contains(firstName)).ToList();
                    DataTable dt = new DataTable();
                    dt.Clear();

                    dt.Columns.Add("ID");
                    dt.Columns.Add("First Name");
                    dt.Columns.Add("Last Name");

                    foreach (Student std in studentList)
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = std.Id;
                        dr[1] = std.FirstName;
                        dr[2] = std.LastName;
                        dt.Rows.Add(dr);
                    }
                    StudentGridView.DataSource = dt;
                    StudentGridView.DataBind();
                }
                else if (byLname_rdb.Checked)
                {
                    string lastName = QueryBox.Text;
                    var studentList = db.Students.Where(s => s.LastName.Contains(lastName)).ToList();
                    DataTable dt = new DataTable();
                    dt.Clear();

                    dt.Columns.Add("ID");
                    dt.Columns.Add("First Name");
                    dt.Columns.Add("Last Name");

                    foreach (Student std in studentList)
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = std.Id;
                        dr[1] = std.FirstName;
                        dr[2] = std.LastName;
                        dt.Rows.Add(dr);
                    }
                    StudentGridView.DataSource = dt;
                    StudentGridView.DataBind();
                }
            }
        }
    }
}