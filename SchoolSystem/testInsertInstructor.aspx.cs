using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolSystem.Models;


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