using SchoolSystem.Models;
using System;
using System.Linq;

namespace SchoolSystem
{
    public partial class testInsertSubject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Subject subj = new Subject();
                subj.Name = txtName.Text;
                subj.Instructor = db.Instructors.Where(i => i.FirstName == Instructor_ddl.Text).FirstOrDefault();
                subj.ScheduleDay = (Subject.ScheduleDays)Int32.Parse(Schedule_ddl.Text);
                db.Subjects.Add(subj);
                db.SaveChanges();
                lbltable_name.Text = subj.Name;
                lbltable_instructor.Text = subj.Instructor.FirstName;
                lbltable_schedule.Text = subj.ScheduleDay.ToString();
                CreationMesssage.Text = "The Subject Profile has been created successfully.";
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }
    }
}