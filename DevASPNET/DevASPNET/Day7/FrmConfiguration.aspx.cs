using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Configuration;

namespace DevASPNET.Day7
{
    public partial class FrmConfiguration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSiteName.Text = WebConfigurationManager.AppSettings["SITE_NAME"].ToString();
            lblCompanyName.Text = WebConfigurationManager.AppSettings["COMPANY_NAME"].ToString();
        }
    }
}