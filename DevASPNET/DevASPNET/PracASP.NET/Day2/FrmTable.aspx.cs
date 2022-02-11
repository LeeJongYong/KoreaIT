using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day2
{
    public partial class FrmTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // [!] 동적으로 1행 1열 테이블 만들기
            // [1] 행 하나 추가
            TableRow tr = new TableRow();
            // [2] 열 하나 추가
            TableCell td = new TableCell();
            // [3] 내용 추가
            LiteralControl lc = new LiteralControl();
            lc.Text = "2번째 테이블";
            // 열에 텍스트 추가
            td.Controls.Add(lc);
            // 행에 열 추가
            tr.Controls.Add(td);
            // 테이블에 행 추가
            Table2.Rows.Add(tr);
            Table2.BorderWidth = 4;
        }
    }
}