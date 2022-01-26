using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day3
{
    public partial class FrmRadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            radioMan.Text = "남자";
            optWomen.Text = "여자";
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            string strMsg = "당신은 ";
            if (radioMan.Checked)
            {
                strMsg += "남자입니다.<br/>";
            }
            else
            {
                strMsg += "여자입니다.<br/>";
            }
            lblDisplay.Text = strMsg;
        }
    }
}