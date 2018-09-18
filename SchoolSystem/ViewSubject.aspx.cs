using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SchoolSystem.Models;

namespace SchoolSystem
{
    public partial class ViewSubject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string qString = Request.QueryString["selectedId"];
                int selectedId = Int32.Parse(qString);
                ViewASubject(selectedId);
            }
            catch (ArgumentNullException)
            {
                Response.Redirect("ErrorPage.aspx");
            }
        }

        private void ViewASubject(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Subject subject = db.Subjects.Include("Instructor").Where(s => s.Id == selectedId).FirstOrDefault();

                Instructor instructor = subject.Instructor;

                lbl_id.Text = subject.Id.ToString();

                lbl_name.Text = subject.Name;
                lbl_schedule.Text = subject.ScheduleDay.ToString();
                lbl_instructor.Text = instructor.FirstName + " " + instructor.LastName;
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedId = Int32.Parse(lbl_id.Text);
            DeleteASubject(selectedId);
        }

        private void DeleteASubject(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Subject subject = new Subject();
                subject = db.Subjects.Where(s => s.Id == selectedId).FirstOrDefault();
                db.Subjects.Remove(subject);
                db.SaveChanges();
                QueryMessage.Text = "The Subject has been deleted successfully";
            }
        }
    }
}