using SchoolSystem.Models;
using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class SearchSubject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            using (SchoolDBContext db = new SchoolDBContext())
            {
                if (byId_rdb.Checked)
                {
                    try
                    {
                        int id = Int32.Parse(QueryBox.Text);
                        Subject subject = db.Subjects.Find(id);
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("Name");

                        DataRow dr = dt.NewRow();
                        dr[0] = subject.Id;
                        dr[1] = subject.Name;

                        dt.Rows.Add(dr);

                        SubjectGridView.DataSource = dt;
                        SubjectGridView.DataBind();
                    }
                    catch (NullReferenceException)
                    {
                        lblExceptionsMsg.Text = "Invalid ID entered. Please re-enter a valid ID";
                    }
                    catch (Exception ex)
                    {
                        lblExceptionsMsg.Text = "Unknown Error, Please re-submit your inquiry. Exception Message : " + ex.Message;
                    }
                }
                else if (byName_rdb.Checked)
                {
                    try
                    {
                        string name = QueryBox.Text;
                        var subjectList = db.Subjects.Where(s => s.Name.Contains(name)).ToList();
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("Name");

                        foreach (Subject subject in subjectList)
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = subject.Id;
                            dr[1] = subject.Name;
                            dt.Rows.Add(dr);
                        }
                        SubjectGridView.DataSource = dt;
                        SubjectGridView.DataBind();
                    }
                    catch (NullReferenceException)
                    {
                        lblExceptionsMsg.Text = "Invalid Name entered. Please re-enter a valid Name";
                    }
                    catch (Exception ex)
                    {
                        lblExceptionsMsg.Text = "Unknown Error, Please re-submit your inquiry. Exception Message : " + ex.Message;
                    }
                }
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperuserDashboard.aspx");
        }

        protected void SubjectGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                string selectedId = SubjectGridView.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text;
                Response.Redirect("ViewSubject.aspx?selectedId=" + selectedId);
            }
        }
    }
}