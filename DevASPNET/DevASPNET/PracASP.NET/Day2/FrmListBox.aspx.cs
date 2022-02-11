using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day2
{
    public partial class FrmListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            string strMsg = String.Empty;

            for (int i = 0; i < ListHobby.Items.Count; i++)
            {
                if (ListHobby.Items[i].Selected)
                {
                    strMsg += ListHobby.Items[i];
                    if(i != ListHobby.Items.Count - 1)
                    {
                        strMsg += ", ";
                    }
                }
            }
            printLabel.Text = strMsg;
        }
    }
}