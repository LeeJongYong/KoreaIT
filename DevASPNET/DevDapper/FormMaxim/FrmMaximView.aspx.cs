using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevDapper.Models;
using DevDapper.Repositories;

namespace DevDapper.FormMaxim
{
    public partial class FrmMaximView : System.Web.UI.Page
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
            int id = Convert.ToInt32(Request.QueryString["Id"]);

            MaximServiceRepository repo = new MaximServiceRepository();
            Maxim maxim = repo.GetMaximById(id);

            lblId.Text = id.ToString();
            lblName.Text = maxim.Name;
            lblContent.Text = maxim.Content;

            btnModify.NavigateUrl = "FrmMaximModify.aspx?Id=" + id;
            btnDelete.NavigateUrl = "FrmMaximDelete.aspx?Id=" + id;

        }
    }
}