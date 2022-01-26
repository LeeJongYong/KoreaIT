using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day3
{
    public partial class FrmCalendarQueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["Date"]))
            {
                lblDate.Text = Request.QueryString["Date"];
            }
            else
            {
                lblDate.Text = "없습니다";
            }
        }

        protected void calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = calendar1.SelectedDate;

            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            string strUrl = String.Format("{3}?Date={0}-{1}-{2}", year, month, day, Request.ServerVariables["script_name"]);
            Response.Redirect(strUrl);
        }
    }
}