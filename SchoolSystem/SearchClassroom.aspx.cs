using SchoolSystem.Models;
using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class SearchClassroom : System.Web.UI.Page
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
                        Classroom classroom = db.Classrooms.Find(id);
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Capacity");

                        DataRow dr = dt.NewRow();
                        dr[0] = classroom.Id;
                        dr[1] = classroom.Name;
                        dr[2] = classroom.Capacity.ToString();
                        dt.Rows.Add(dr);

                        ClassroomGridView.DataSource = dt;
                        ClassroomGridView.DataBind();
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
                        var classroomList = db.Classrooms.Where(c => c.Name.Contains(name)).ToList();
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Capacity");

                        foreach (Classroom classroom in classroomList)
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = classroom.Id;
                            dr[1] = classroom.Name;
                            dr[2] = classroom.Capacity.ToString();
                            dt.Rows.Add(dr);
                        }
                        ClassroomGridView.DataSource = dt;
                        ClassroomGridView.DataBind();
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
                else if (byCapacity_rdb.Checked)
                {
                    try
                    {
                        int cap = Int32.Parse(QueryBox.Text);
                        var classroomList = db.Classrooms.Where(c => c.Capacity == cap).ToList();
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Capacity");

                        foreach (Classroom classroom in classroomList)
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = classroom.Id;
                            dr[1] = classroom.Name;
                            dr[2] = classroom.Capacity.ToString();
                            dt.Rows.Add(dr);
                        }
                        ClassroomGridView.DataSource = dt;
                        ClassroomGridView.DataBind();
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

        protected void ClassroomGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                string selectedId = ClassroomGridView.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text;
                Response.Redirect("ViewClassroom.aspx?selectedId=" + selectedId);
            }
        }
    }
}