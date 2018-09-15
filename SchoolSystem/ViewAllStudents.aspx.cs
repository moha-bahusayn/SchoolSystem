using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class testViewAllStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }

        protected void StudentsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                string selectedId = StudentsGridView.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text;
                Response.Redirect("ViewStudent.aspx?selectedId=" + selectedId);
            }
        }
    }
}