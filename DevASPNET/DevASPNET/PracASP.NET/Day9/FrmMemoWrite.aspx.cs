using DevASPNET.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day9
{
    public partial class FrmMemoWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Memo memo = new Memo();
            memo.Name = txtName.Text;
            memo.Email = txtEmail.Text;
            memo.Title = txtTitle.Text;
            memo.PostDate = DateTime.Now;
            memo.PostIP = Request.UserHostAddress;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("writeMemo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", memo.Name);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Title", memo.Title);
            cmd.Parameters.AddWithValue("@PostIP", memo.PostIP);

            cmd.ExecuteNonQuery();
            con.Close();
            lblDisplay.Text = "저장되었습니다.";
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMemoList.aspx");
        }
    }
}