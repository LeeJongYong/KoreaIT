using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET
{
    public partial class FrmApplicationSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Application["count"] == null)
            {
                Application.Lock();
                Application["count"] = 1;
                Application.UnLock();
            }
            else
            {
                Application["count"] = (int)Application["count"] + 1;
            }

            if(Session["count"] == null)
            {
                Session["count"] = 1;
            }
            else
            {
                Session["count"] = (int)Session["count"] + 1;
            }

            lblApplication.Text = Application["count"].ToString();
            lblSession.Text = Session["count"].ToString();
            lblSessionID.Text = Session.SessionID;
            lblTimeout.Text = Session.Timeout.ToString();
        }
    }
}