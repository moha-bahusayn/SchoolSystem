using SchoolSystem.Models;
using System;

namespace SchoolSystem
{
    public partial class InsertStudent : System.Web.UI.Page
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
                lbltable_fName.Text = stud.FirstName;
                lbltable_lName.Text = stud.LastName;
                lbltable_email.Text = stud.EmailAddress;
                lbltable_mobile.Text = stud.MobileNumber;
                CreationMesssage.Text = "The Student Profile has been created successfully.";
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }
    }
}