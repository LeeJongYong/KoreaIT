using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DevASPNET.PracASP.NET.Day9
{
    public partial class FrmMemoView : System.Web.UI.Page
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
                DisplayData();
                lnkModify.NavigateUrl = $"FrmMemoModify.aspx?Num={Request["Num"]}";
                lnkDelete.NavigateUrl = $"FrmMemoDelete.aspx?Num={Request["Num"]}";
            }
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("ViewMemo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("Num", SqlDbType.Int);
            cmd.Parameters["Num"].Value = Convert.ToInt32(Request["Num"]);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblNum.Text = Request["Num"];
                lblName.Text = dr["Name"].ToString();
                lblEmail.Text = dr[2].ToString();
                lblTitle.Text = dr.GetString(3);
                lblPostDate.Text = dr.GetDateTime(4).ToString();
                lblPostIP.Text = dr.GetString(5);
            }
            else
            {
                Response.Write("존재하지 않는 정보입니다.");
                Response.End();
            }

            dr.Close();
            con.Close();

        }
    }
}