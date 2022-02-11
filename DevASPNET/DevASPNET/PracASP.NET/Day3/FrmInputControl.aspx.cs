using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day3
{
    public partial class FrmInputControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page.IsPostBack : 처음로드하면 false, 포스트백하면 true
            if (!Page.IsPostBack)
            {
                BindFavorite();
            }
        }

        private void BindFavorite()
        {
            // 동적으로 Listitem 채우기
            lstFavorite.Items.Add("C#");
            lstFavorite.Items.Add("ASP.NET");

            ListItem li = new ListItem();
            li.Text = "Script";
            li.Value = "TypeScript";
            lstFavorite.Items.Add(li);

            ListItem listItem = new ListItem("닷넷", ".net");
            lstFavorite.Items.Add(listItem);

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            // [0] 문자열 변수 선언 : StringBuilder 클래스 사용
            StringBuilder sb = new StringBuilder();

            // [1] 체크박스의 내용 가져오기
            if (chkAgree.Checked)
            {
                sb.Append("[1] " + chkAgree.Text + "<br/>");
            }

            // [2] 체크박스 리스트 내용 가져오기
            for (int i = 0; i < listHobby.Items.Count; i++)
            {
                if (listHobby.Items[i].Selected)
                {
                    sb.Append("[2] " + listHobby.Items[i].Value + "<br/>");
                }
            }

            // [3] 라디오버튼 값 받아오기
            if (rdoMan.Checked)
            {
                sb.Append("[3] " + rdoMan.Text + " 선택<br/>");
            }
            else
            {
                sb.Append("[3] " + rdoWomen.Text + " 선택<br/>");
            }

            // [4] 라디오버튼 리스트 값 받아오기
            sb.AppendFormat("[4] {0}<br/>", lstWedding.SelectedItem.Text);

            // [5] 드롭다운 리스트 값 받아오기
            sb.AppendFormat("[5] {0}<br/>", lstJob.Items[lstJob.SelectedIndex].Text);

            // [6] 리스트박스
            foreach (ListItem li in lstFavorite.Items)
            {
                if (li.Selected)
                {
                    sb.Append("[6] " + li.Text + "<br/>");
                }
            }

            lblDisplay.Text = sb.ToString();
            
        }
    }
}