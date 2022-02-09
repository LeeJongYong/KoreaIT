using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day4
{
    public partial class FrmRequiredFieldValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page.SetFocus(txtUserId);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                                // 특정 자바스크립트 코드를 실행하는 기능을 한다  
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alertMessage", "<script>alert('통과');</script>");
            }
        }
    }
}