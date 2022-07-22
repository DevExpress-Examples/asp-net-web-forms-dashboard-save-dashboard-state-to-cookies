using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;
using System.Web;

namespace WebDashboard_DashboardStateCookies {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {            
        }

        protected void ASPxDashboard1_SetInitialDashboardState(object sender, SetInitialDashboardStateEventArgs e) {
            // Requests the "dashboardState" cookie:
            HttpCookie cookie = Request.Cookies["dashboardState"];
            if (cookie != null) {
                DashboardState dashboardState = new DashboardState();
                // Initializes a DevExpress.DashboardCommon.DashboardState object from the JSON state:
                dashboardState.LoadFromJson(HttpUtility.UrlDecode(cookie.Value));
                if (e.DashboardId == "dashboard1")
                    // Applies the initial dashboard state if it exists in cookies:
                    e.InitialState = dashboardState;
            }
        }
    }
}
