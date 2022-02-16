using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevUser.Repositories;

namespace DevUser
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            UserRepository uRepo = new UserRepository();
            var model = uRepo.getUserByUserId(Page.User.Identity.Name);

            lblUID.Text = model.id.ToString();
            txtId.Text = model.userId;
            txtPassword.Text = model.password;
        }
        protected void btnModify_Click(object sender, EventArgs e)
        {
            var userRepo = new UserRepository();
            userRepo.modifyUser(Convert.ToInt32(lblUID.Text), txtId.Text, txtPassword.Text);

            string strJs = "<script>alert('수정완료');location.href='Default.aspx';</script>";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "goDefault", strJs);

        }
    }
}