using SchoolSystem.Models;
using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class testSearchStudent : System.Web.UI.Page
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
                        var std = db.Students.Find(id);
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("First Name");
                        dt.Columns.Add("Last Name");

                        DataRow dr = dt.NewRow();
                        dr[0] = std.Id;
                        dr[1] = std.FirstName;
                        dr[2] = std.LastName;
                        dt.Rows.Add(dr);

                        StudentGridView.DataSource = dt;
                        StudentGridView.DataBind();
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
                else if (byFname_rdb.Checked)
                {
                    try
                    {
                        string firstName = QueryBox.Text;
                        var studentList = db.Students.Where(s => s.FirstName.Contains(firstName)).ToList();
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("First Name");
                        dt.Columns.Add("Last Name");

                        foreach (Student std in studentList)
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = std.Id;
                            dr[1] = std.FirstName;
                            dr[2] = std.LastName;
                            dt.Rows.Add(dr);
                        }
                        StudentGridView.DataSource = dt;
                        StudentGridView.DataBind();
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
                else if (byLname_rdb.Checked)
                {
                    try
                    {
                        string lastName = QueryBox.Text;
                        var studentList = db.Students.Where(s => s.LastName.Contains(lastName)).ToList();
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("First Name");
                        dt.Columns.Add("Last Name");

                        foreach (Student std in studentList)
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = std.Id;
                            dr[1] = std.FirstName;
                            dr[2] = std.LastName;
                            dt.Rows.Add(dr);
                        }
                        StudentGridView.DataSource = dt;
                        StudentGridView.DataBind();
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

        protected void StudentGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                string selectedId = StudentGridView.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text;
                Response.Redirect("ViewStudent.aspx?selectedId=" + selectedId);
            }
        }
    }
}