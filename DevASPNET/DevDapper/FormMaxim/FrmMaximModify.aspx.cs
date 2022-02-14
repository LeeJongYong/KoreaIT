using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevDapper.Repositories;
using DevDapper.Models;

namespace DevDapper.FormMaxim
{
    public partial class FrmMaximModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                if (!Page.IsPostBack)
                {
                    DisplayData();
                }
                else
                {
                    Response.Write("잘못된 접근입니다.");
                    Response.End();
                }
            }
        }

        private void DisplayData()
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);

            MaximServiceRepository repo = new MaximServiceRepository();
            Maxim maxim = repo.GetMaximById(id);

            lblId.Text = id.ToString();
            txtName.Text = maxim.Name;
            txtContent.Text = maxim.Content;
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            Maxim maxim = new Maxim();

            maxim.Id = Convert.ToInt32(Request.QueryString["Id"]);
            maxim.Name = txtName.Text;
            maxim.Content = txtContent.Text;

            // 입력받은 데이터로 수정 실행
            MaximServiceRepository repo = new MaximServiceRepository();
            maxim = repo.UpdateMaxim(maxim);

            lblDisplay.Text = maxim.Id.ToString() + "번 데이터가 수정되었습니다.";

            // 해당 데이터 출력
            DisplayData();
        }
    }
}