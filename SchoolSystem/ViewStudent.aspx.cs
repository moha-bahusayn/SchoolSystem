using SchoolSystem.Models;
using System;
using System.Data;
using System.Linq;

namespace SchoolSystem
{
    public partial class ViewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Control the flow.
             * Auto-hide = true for update button and delete button.
             * after view button is clicked, the update and delete buttons are shown along with the label student name.
             * the update and the delete functions should be working with the label student name, not the view txt box.
             */

            try
            {
                string qString = Request.QueryString["selectedId"];
                int selectedId = Int32.Parse(qString);
                ViewAStudent(selectedId);
            }
            catch (ArgumentNullException)
            {
                Response.Redirect("ErrorPage.aspx");
            }
        }

        private void ViewAStudent(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Student std = new Student(); //{ Classroom = {Id = std.Classroom.Id };
                std = db.Students.Where(s => s.Id == selectedId).FirstOrDefault();
                //var cid = std.Classroom.Id; // ERROR

                //Classroom classroom = new Classroom();
                //Classroom classroom = db.Classrooms.Where(c => c.Id == std.Classroom.Id).FirstOrDefault();
                lbl_id.Text = std.Id.ToString();

                //lbl_classroom.Text = classroom.Name;

                lbl_fName.Text = std.FirstName;
                lbl_lName.Text = std.LastName;
                lbl_mobile.Text = std.MobileNumber;
                lbl_email.Text = std.EmailAddress;
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedId = Int32.Parse(lbl_id.Text);
            DeleteAStudent(selectedId);
        }

        private void DeleteAStudent(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Student std = new Student();
                std = db.Students.Where(s => s.Id == selectedId).FirstOrDefault();
                db.Students.Remove(std);
                db.SaveChanges();
                QueryMessage.Text = "The Student Profile has been deleted successfully";
            }
        }

        protected void AddClassBtn_Click(object sender, EventArgs e)
        {
            int selectedId = Int32.Parse(lbl_id.Text);
            AddClass(selectedId);
        }

        private void AddClass(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Student std = new Student();
                std = db.Students.Where(s => s.Id == selectedId).FirstOrDefault();
                std.Classroom = db.Classrooms.Where(c => c.Name == Classroom_ddl.Text).FirstOrDefault();

                db.SaveChanges();
                QueryMessage.Text = "The Student " + std.FirstName + " " + std.LastName + " is enrolled in the class " + std.Classroom.Name;
            }
        }
    }
}