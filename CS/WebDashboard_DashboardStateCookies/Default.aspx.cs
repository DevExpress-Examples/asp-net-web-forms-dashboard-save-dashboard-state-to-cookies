using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;
using System.Web;

namespace WebDashboard_DashboardStateCookies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
        }

        protected void ASPxDashboard1_SetInitialDashboardState(object sender, SetInitialDashboardStateEventArgs e)
        {
            HttpCookie cookie = Request.Cookies["ASPxDashboardState"];
            if (cookie != null)
            {
                DashboardState dashboardState = new DashboardState();
                dashboardState.LoadFromJson(HttpUtility.UrlDecode(cookie.Value));
                if (e.DashboardId == "dashboard1")
                    e.InitialState = dashboardState;
            }
        }
    }
}