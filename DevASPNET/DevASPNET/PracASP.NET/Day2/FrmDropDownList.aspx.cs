using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day2
{
    public partial class FrmDropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!Page.IsPostBack && listJob.Items.Count > 1)
            //{
            //    this.listJob.SelectedIndex = 1;
            //}
        }

        protected void listJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMsg = String.Empty;
            strMsg = listJob.SelectedItem.Text + "을(를) 선택했습니다.";
            listDisplay.Text = strMsg;
        }
    }
}