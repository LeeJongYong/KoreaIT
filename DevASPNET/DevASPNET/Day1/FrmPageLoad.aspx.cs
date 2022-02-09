using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace DevASPNET
{
    public partial class FrmPageLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 타이틀을 바꿀 수 있는 방법 3가지
            Title = "제목이 바뀝니다";
            Page.Title = "제목이 출력됩니다.";
            Page.Header.Title = "Page 클래스";

            // css 정의
            HtmlLink objHtmlLink = new HtmlLink();
            objHtmlLink.Href = "DevASPNET.css";
            objHtmlLink.Attributes.Add("rel", "stylesheet");
            objHtmlLink.Attributes.Add("type", "text/css");
            // 연결
            HtmlHead objHtmlHead = Page.Header;
            objHtmlHead.Controls.Add(objHtmlLink);

            // 버튼 css 적용
            Style objButtonStyle = new Style();
            objButtonStyle.ForeColor = System.Drawing.Color.Navy;
            objButtonStyle.Font.Size = 9;
            objButtonStyle.Font.Name = "Verdana";
            Page.Header.StyleSheet.RegisterStyle(
                objButtonStyle, null);
            btnNewLoad.CssClass = objButtonStyle.RegisteredCssClass;
            btnPostBack.CssClass = objButtonStyle.RegisteredCssClass;

            // div css 적용
            Style objDivStyle = new Style();
            objDivStyle.ForeColor = System.Drawing.Color.Blue;
            objDivStyle.Font.Size = 10;
            objDivStyle.Font.Name = "Verdana";
            objDivStyle.Font.Italic = true;
            Page.Header.StyleSheet.CreateStyleRule(objDivStyle, null, "body, div");


            if (!Page.IsPostBack)
            {
                Response.Write("[1] 폼이 처음 로드<br/>");
            }
            if(Page.IsPostBack == false)
            {
                Response.Write("[2] 폼이 처음 로드할 때만 실행<br/>");
            }
            Response.Write("[3] 폼이 로드<br/>");
        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            string strJs = @"<script> window.alert('포스트백');</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", strJs);
        }

        protected void btnNewLoad_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmPageLoad.aspx");
        }
    }
}