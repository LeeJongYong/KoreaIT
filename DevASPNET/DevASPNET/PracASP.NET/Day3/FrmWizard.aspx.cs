using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day3
{
    public partial class FrmWizard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            string msg = "";
            msg += this.txtStart.Text + "<br/>";
            msg += this.txtStep1.Text + "<br/>";
            msg += this.txtStep2.Text + "<br/>";
            msg += this.txtFinish.Text + "<br/>";
            lblComplete.Text = msg;
        }
    }
}  