using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserId = "";
            string strPassword = String.Empty;
            string strName = "";
            string strAge = String.Empty;

            strUserId = Request.QueryString["UserID"];
            strPassword = Request.Params["Password"];
            strName = Request.Form["Name"];
            strAge = Request["Age"];

            string strMsg = String.Format($"입력하신 아이디는 {strUserId}이고 <br/>" +
                $"암호는 {strPassword}입니다.<br/>" +
                $"이름은 {strName}이고,<br/>" +
                $"나이는 {strAge}입니다.");

            Response.Write(strMsg);

        }
        protected void btnSummit_Click(object sender, EventArgs e)
        {
            //string name = Name.Text;
            //int age = Convert.ToInt32(Age.Text);
        }
    }
}