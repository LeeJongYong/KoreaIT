using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day3
{
    public partial class FrmHiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ctlHidden.Value = DateTime.Now.ToString();
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            Response.Write(ctlHidden.Value);
        }
    }
}