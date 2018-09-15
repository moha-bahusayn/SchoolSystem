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
                db.SaveChanges(); lbltable_fName.Text = instruct.FirstName;
                lbltable_lName.Text = instruct.LastName;
                lbltable_email.Text = instruct.EmailAddress;
                lbltable_mobile.Text = instruct.MobileNumber;
                CreationMesssage.Text = "The Instructor Profile has been created successfully.";
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }
    }
}