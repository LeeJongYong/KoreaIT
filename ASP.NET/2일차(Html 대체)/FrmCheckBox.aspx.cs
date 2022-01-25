using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day2
{
    public partial class FrmCheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            string strMsg = String.Empty;

            if (chkCSharp.Checked)
            {
                strMsg += chkCSharp.Text;
            }
            if (chkDotNet.Checked)
            {
                strMsg += chkDotNet.Text;
            }
            printBox.Text = strMsg;
        }
    }
}