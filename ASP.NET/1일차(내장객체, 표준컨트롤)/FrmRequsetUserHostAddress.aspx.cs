using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET
{
    public partial class FrmRequsetUserHostAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.UserHostAddress;
            Label2.Text = Request.ServerVariables["REMOTE_HOST"];
            Label3.Text = Request.ServerVariables["REMOTE_ADDR"];

        }
    }
}