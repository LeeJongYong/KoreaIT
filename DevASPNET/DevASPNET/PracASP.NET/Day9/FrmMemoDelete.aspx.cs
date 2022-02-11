using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevASPNET.Models;

namespace DevASPNET.PracASP.NET.Day9
{
    public partial class FrmMemoDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request["Num"]))
            {
                Response.Write("잘못된 접근입니다.");
                Response.End();
            }
            else
            {
                if (!Page.IsPostBack)
                {
                    lblNum.Text = Request["Num"];
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteMemo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("Num", SqlDbType.Int);
            cmd.Parameters["Num"].Value = Convert.ToInt32(Request["Num"]);

            cmd.ExecuteNonQuery();

            con.Close();
            Response.Redirect("FrmMemoList.aspx");
        }
    }
}