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
    public partial class ViewClassroom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string qString = Request.QueryString["selectedId"];
                int selectedId = Int32.Parse(qString);
                ViewAClassroom(selectedId);
            }
            catch (ArgumentNullException)
            {
                Response.Redirect("ErrorPage.aspx");
            }
        }

        private void ViewAClassroom(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Classroom classroom = new Classroom();
                classroom = db.Classrooms.Where(c => c.Id == selectedId).FirstOrDefault();

                lbl_id.Text = classroom.Id.ToString();

                lbl_name.Text = classroom.Name;
                lbl_capacity.Text = classroom.Capacity.ToString();
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedId = Int32.Parse(lbl_id.Text);
            DeleteAClassroom(selectedId);
        }

        private void DeleteAClassroom(int selectedId)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Classroom classroom = new Classroom();
                classroom = db.Classrooms.Where(c => c.Id == selectedId).FirstOrDefault();
                db.Classrooms.Remove(classroom);
                db.SaveChanges();
                QueryMessage.Text = "The Classroom has been deleted successfully";
            }
        }
    }
}