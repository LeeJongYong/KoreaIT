using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevDapper.Repositories;

namespace DevDapper.FormMaxim
{
    public partial class FrmMaximList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }
        
        private void DisplayData()
        {
            MaximServiceRepository repo = new MaximServiceRepository();

            lstMaxim.DataSource = repo.GetMaxims();
            lstMaxim.DataBind();
        }
    }
}