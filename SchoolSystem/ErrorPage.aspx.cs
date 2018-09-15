using System;

namespace SchoolSystem
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    ViewState["RefUrl"] = Request.UrlReferrer.ToString();
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            object refUrl = ViewState["RefUrl"];
            if (refUrl != null)
                Response.Redirect((string)refUrl);
        }
    }
}