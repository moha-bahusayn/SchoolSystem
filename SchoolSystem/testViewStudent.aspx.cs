using SchoolSystem.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace SchoolSystem
{
    public partial class testViewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Control the flow.
             * Auto-hide = true for update button and delete button.
             * after view button is clicked, the update and delete buttons are shown along with the label student name.
             * the update and the delete functions should be working with the label student name, not the view txt box.
             */
        }

        protected void ViewBtn_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                string firstName = View_txt.Text;
                //var studentList = db.Students.Where(s => s.FirstName.Contains(firstName)).ToList();
                Student std = new Student();
                std = db.Students.Where(s => s.FirstName.Contains(firstName)).FirstOrDefault();
                DataTable dt = new DataTable();
                dt.Clear();

                dt.Columns.Add("ID");
                dt.Columns.Add("First Name");
                dt.Columns.Add("Last Name");

                //foreach (Student std in studentList)
                //{
                DataRow dr = dt.NewRow();
                dr[0] = std.Id;
                dr[1] = std.FirstName;
                dr[2] = std.LastName;
                dt.Rows.Add(dr);
                //}
                StudentGridView.DataSource = dt;
                StudentGridView.DataBind();
                lblFirstName.Text = std.FirstName; //+ " " + std.LastName;
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                //if (Update_txt.Text.Contains(number))
                //{
                //No Update happens. request valid info again from end user.
                //}

                string firstName = lblFirstName.Text;
                //var studentList = db.Students.Where(s => s.FirstName.Contains(firstName)).ToList();
                Student std = new Student();
                std = db.Students.Where(s => s.FirstName.Contains(firstName)).FirstOrDefault();

                //foreach (Student std in studentList)
                //{
                std.FirstName = Update_txt.Text;
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

                lblFirstName.Text = std.FirstName;
                //}
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                //if (Update_txt.Text.Contains(number))
                //{
                //No Update happens. request valid info again from end user.
                //}

                string firstName = lblFirstName.Text;

                //var studentList = db.Students.Where(s => s.FirstName.Contains(firstName)).ToList();
                Student std = new Student();
                std = db.Students.Where(s => s.FirstName.Contains(firstName)).FirstOrDefault();
                //foreach (Student std in studentList)
                //{
                db.Students.Remove(std);
                db.Entry(std).State = EntityState.Deleted;
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
                //}
            }
        }
    }
}