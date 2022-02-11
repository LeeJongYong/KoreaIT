using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day8
{
    public partial class FrmSqlCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSqlCommand_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"insert into Memos
                                values
                                (
                                    N'홍길동', N'11@111.com', N'홍길동이다', getdate(), '127.0.0.2'
                                )
                                ";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            lblDisplay.Text = "저장완료";

            con.Close();
        }
    }
}