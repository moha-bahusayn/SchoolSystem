using SchoolSystem.Models;
using System;

namespace SchoolSystem
{
    public partial class testInsertInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Instructor instruct = new Instructor();
                instruct.FirstName = txtFName.Text;
                instruct.LastName = txtLName.Text;
                instruct.MobileNumber = txtMobile.Text;
                instruct.EmailAddress = txtEmail.Text;

                db.Instructors.Add(instruct);
                db.SaveChanges();
            }
        }
    }
}