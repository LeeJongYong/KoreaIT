using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace DevASPNET
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // 애플리케이션 시작 시 실행되는 코드
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            System.Web.UI.ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.WebForms;
            Application["Now"] = DateTime.Now;
            Application["CurrentVisit"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Now"] = DateTime.Now;
            Application.Lock();
            Application["CurrentVisit"] = (int)Application["CurrentVisit"] + 1;
            Application.UnLock();
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["CurrentVisit"] = (int)Application["CurrentVisit"] - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Application["CurrentVisit"] = null;
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }
    }
}