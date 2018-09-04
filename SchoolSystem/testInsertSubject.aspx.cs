using SchoolSystem.Models;
using System;

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
                db.Subjects.Add(subj);
                db.SaveChanges();
            }
        }
    }
}