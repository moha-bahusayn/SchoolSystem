using System;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class ViewAllSubjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }

        protected void SubjectsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                string selectedId = SubjectsGridView.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text;
                Response.Redirect("ViewSubject.aspx?selectedId=" + selectedId);
            }
        }
    }
}