using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day2
{
    public partial class FrmBulletedLis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void listFavorite_Click(object sender, BulletedListEventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("선택 항목 : <br/>");
            sb.Append(listFavorite.Items[e.Index].Text);

            Response.Write(sb.ToString());
        }
    }
}