using SchoolSystem.Models;
using System;
using System.Globalization;

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
                CultureInfo provider = CultureInfo.InvariantCulture;
                string format = "dd/MM/yyyy";
                stud.DateOfBirth = DateTime.ParseExact(txtDob.Text, format, provider);
                db.Students.Add(stud);
                db.SaveChanges();
                lbltable_fName.Text = stud.FirstName;
                lbltable_lName.Text = stud.LastName;
                lbltable_email.Text = stud.EmailAddress;
                lbltable_mobile.Text = stud.MobileNumber;
                string format_display = "dd MMM yyyy";
                lbltable_dob.Text = stud.DateOfBirth.ToString(format_display, provider);
                //lbltable_dob.Text = stud.DateOfBirth.ToShortDateString();
                CreationMesssage.Text = "The Student Profile has been created successfully.";
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }
    }
}