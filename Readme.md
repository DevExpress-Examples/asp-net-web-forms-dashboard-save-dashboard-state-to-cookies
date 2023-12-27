<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579930/19.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T513329)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebDashboard_DashboardStateCookies/Default.aspx) (VB: [Default.aspx](./VB/WebDashboard_DashboardStateCookies/Default.aspx))
* [Default.aspx.cs](./CS/WebDashboard_DashboardStateCookies/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebDashboard_DashboardStateCookies/Default.aspx.vb))
<!-- default file list end -->

# ASPxDashboard - How to save a dashboard state to cookies

The sample illustrates how to save the current ASPxDashboard state (such as master filter or parameter values) to cookies on the client side and restore this state on the server side. The following API is used in this example

* The [DashboardControlOptions.onDashboardStateChanged](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions?p=netframework#js_devexpress_dashboard_dashboardcontroloptions_ondashboardstatechanged) event is handled to obtain the current dashboard state.
* The [ASPxClientUtils.SetCookie](https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientUtils_SetCookietopic) client-side method is used to save the dashboard state to cookies.
* In the [ASPxDashboard.SetInitialDashboardState](https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboard_SetInitialDashboardStatetopic) event handler, the dashboard state is loaded from the cookies and applied to a dashboard.


