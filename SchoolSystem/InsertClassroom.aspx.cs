using SchoolSystem.Models;
using System;

namespace SchoolSystem
{
    public partial class testInsertClassroom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Classroom room = new Classroom();
                room.Name = txtName.Text;
                room.Capacity = Int32.Parse(txtCapacity.Text);
                db.Classrooms.Add(room);
                db.SaveChanges();
                lbltable_name.Text = room.Name;
                lbltable_capacity.Text = room.Capacity.ToString();
                CreationMesssage.Text = "The Classroom Profile has been created successfully.";
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }
    }
}