using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day6
{
    public partial class FrmStateShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtApplication.Text = Application["Now"].ToString();
            txtSession.Text = Session["Now"].ToString();

            if (Cache["Now"] != null)
            {
                txtCache.Text = Cache["Now"].ToString();
            }

            if (Request.Cookies["Now"] != null)
            {
                txtCookies.Text = Request.Cookies["Now"].Value;
            }

            if (ViewState["Now"] != null)
            {
                txtViewState.Text = ViewState["Now"].ToString();
            }
        }
    }
}