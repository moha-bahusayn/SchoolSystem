using SchoolSystem.Models;
using System;
using System.Data;
using System.Linq;

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
                try
                {
                    lbl_instructor.Text = instructor.FirstName + " " + instructor.LastName;
                }
                catch (NullReferenceException)
                {
                    lbl_instructor.Text = "";
                }
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

        protected void AssignInstructorBtn_Click(object sender, EventArgs e)
        {
            int selectedId = Int32.Parse(lbl_id.Text);
            AssignAnInstructor(selectedId);
        }

        private void AssignAnInstructor(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Subject subject = db.Subjects.Include("Instructor").Where(s => s.Id == selectedId).FirstOrDefault();
                subject.Instructor = db.Instructors.Where(i => i.Id.ToString() == Instructor_ddl.SelectedValue).FirstOrDefault();

                db.SaveChanges();
                lbl_instructor.Text = subject.Instructor.FirstName + " " + subject.Instructor.LastName;
                QueryMessage.Text = "The Instructor " + subject.Instructor.FirstName + " " + subject.Instructor.LastName
                                    + " is now the assigned instructor for the subject: " + subject.Name;
            }
        }

        protected void AddStudentBtn_Click(object sender, EventArgs e)
        {
            int selectedId = Int32.Parse(lbl_id.Text);
            AddAStudent(selectedId);
        }

        private void AddAStudent(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Subject subject = new Subject();
                subject = db.Subjects.Include("Students").Where(s => s.Id == selectedId).FirstOrDefault();
                Student student = db.Students.Where(s => s.Id.ToString() == Student_ddl.SelectedValue).FirstOrDefault();
                subject.Students.Add(student);
                //show data in SubStdGridView;
                db.SaveChanges();
                QueryMessage.Text = "The Student is enrolled in the subject.";
            }
        }
    }
}