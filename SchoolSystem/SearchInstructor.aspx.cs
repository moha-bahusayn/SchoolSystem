using SchoolSystem.Models;
using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class SearchInstructor : System.Web.UI.Page
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
                        Instructor instructor = db.Instructors.Find(id);
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("First Name");
                        dt.Columns.Add("Last Name");

                        DataRow dr = dt.NewRow();
                        dr[0] = instructor.Id;
                        dr[1] = instructor.FirstName;
                        dr[2] = instructor.LastName;
                        dt.Rows.Add(dr);

                        InstructorGridView.DataSource = dt;
                        InstructorGridView.DataBind();
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
                        var instructorList = db.Instructors.Where(i => i.FirstName.Contains(firstName)).ToList();
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("First Name");
                        dt.Columns.Add("Last Name");

                        foreach (Instructor instructor in instructorList)
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = instructor.Id;
                            dr[1] = instructor.FirstName;
                            dr[2] = instructor.LastName;
                            dt.Rows.Add(dr);
                        }
                        InstructorGridView.DataSource = dt;
                        InstructorGridView.DataBind();
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
                        var instructorList = db.Instructors.Where(i => i.LastName.Contains(lastName)).ToList();
                        DataTable dt = new DataTable();
                        dt.Clear();

                        dt.Columns.Add("ID");
                        dt.Columns.Add("First Name");
                        dt.Columns.Add("Last Name");

                        foreach (Instructor instructor in instructorList)
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = instructor.Id;
                            dr[1] = instructor.FirstName;
                            dr[2] = instructor.LastName;
                            dt.Rows.Add(dr);
                        }
                        InstructorGridView.DataSource = dt;
                        InstructorGridView.DataBind();
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

        protected void InstructorGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                string selectedId = InstructorGridView.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text;
                Response.Redirect("ViewInstructor.aspx?selectedId=" + selectedId);
            }
        }
    }
}