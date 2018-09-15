using System;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class ViewAllInstructors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }

        protected void InstructorsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                string selectedId = InstructorsGridView.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text;
                Response.Redirect("ViewInstructor.aspx?selectedId=" + selectedId);
            }
        }
    }
}