using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class ViewAllClassrooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }

        protected void ClassroomsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                string selectedId = ClassroomsGridView.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text;
                Response.Redirect("ViewClassroom.aspx?selectedId=" + selectedId);
            }
        }
    }
}