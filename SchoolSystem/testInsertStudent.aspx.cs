using SchoolSystem.Models;
using System;

namespace SchoolSystem
{
    public partial class tesetInsertStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                Student stud = new Student();
                stud.FirstName = txtFName.Text;
                stud.LastName = txtLName.Text;
                stud.MobileNumber = txtMobile.Text;
                stud.EmailAddress = txtEmail.Text;

                db.Students.Add(stud);
                db.SaveChanges();
            }
        }
    }
}