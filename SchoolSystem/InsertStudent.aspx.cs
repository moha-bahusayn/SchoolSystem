using SchoolSystem.Models;
using System;
using System.Globalization;
using System.Linq;

namespace SchoolSystem
{
    public partial class InsertStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            infoTable.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                infoTable.Visible = true;

                Student stud = new Student();
                stud.FirstName = txtFName.Text;
                stud.LastName = txtLName.Text;
                stud.MobileNumber = txtMobile.Text;
                stud.EmailAddress = txtEmail.Text;
                stud.Hobbies = txtHobbies.Text;
                Classroom classroom = db.Classrooms.Where(c => c.Id.ToString() == Classroom_ddl.SelectedValue).FirstOrDefault();
                stud.Classroom = classroom;
                CultureInfo provider = CultureInfo.InvariantCulture;
                string format = "dd/MM/yyyy";
                if(!string.IsNullOrEmpty(txtDob.Text))
                {
                    stud.DateOfBirth = DateTime.ParseExact(txtDob.Text, format, provider);
                }
                db.Students.Add(stud);
                db.SaveChanges();
                lbltable_fName.Text = stud.FirstName;
                lbltable_lName.Text = stud.LastName;
                lbltable_email.Text = stud.EmailAddress;
                lbltable_mobile.Text = stud.MobileNumber;
                lbltable_hobbies.Text = stud.Hobbies;
                lbltable_classroom.Text = stud.Classroom.Name;

                string format_display = "dd MMM yyyy";
                lbltable_dob.Text = stud.DateOfBirth.ToString(format_display, provider);
                CreationMesssage.Text = "The Student Profile has been created successfully.";
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }
    }
}