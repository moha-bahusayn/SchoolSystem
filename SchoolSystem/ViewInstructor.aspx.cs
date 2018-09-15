using SchoolSystem.Models;
using System;
using System.Data;
using System.Linq;

namespace SchoolSystem
{
    public partial class ViewInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string qString = Request.QueryString["selectedId"];
                int selectedId = Int32.Parse(qString);
                ViewAnInstructor(selectedId);
            }
            catch (ArgumentNullException)
            {
                Response.Redirect("ErrorPage.aspx");
            }
        }

        private void ViewAnInstructor(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Instructor instructor = new Instructor();
                instructor = db.Instructors.Where(i => i.Id == selectedId).FirstOrDefault();

                lbl_id.Text = instructor.Id.ToString();

                lbl_fName.Text = instructor.FirstName;
                lbl_lName.Text = instructor.LastName;
                lbl_mobile.Text = instructor.MobileNumber;
                lbl_email.Text = instructor.EmailAddress;
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedId = Int32.Parse(lbl_id.Text);
            DeleteAnInstructor(selectedId);
        }

        private void DeleteAnInstructor(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Instructor instructor = new Instructor();
                instructor = db.Instructors.Where(i => i.Id == selectedId).FirstOrDefault();
                db.Instructors.Remove(instructor);
                db.SaveChanges();
                QueryMessage.Text = "The Instructor Profile has been deleted successfully";
            }
        }
    }
}