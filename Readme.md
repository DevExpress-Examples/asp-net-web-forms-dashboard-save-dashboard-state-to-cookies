<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579930/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T513329)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebDashboard_DashboardStateCookies/Default.aspx) (VB: [Default.aspx](./VB/WebDashboard_DashboardStateCookies/Default.aspx))
* [Default.aspx.cs](./CS/WebDashboard_DashboardStateCookies/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebDashboard_DashboardStateCookies/Default.aspx.vb))
<!-- default file list end -->
# ASPxDashboard - How to save a dashboard state to cookies


<p>The sample illustrates how to save the current ASPxDashboard state (such as master filter or parameter values) to cookies on the client side and restore this state on the server side. The following API is used in this example

* The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboard_DashboardStateChangedtopic">ASPxClientDashboard.DashboardStateChanged</a> event is handled to obtain the current dashboard state.
* The <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientUtils_SetCookietopic">ASPxClientUtils.SetCookie</a> client-side method is used to save the dashboard state to cookies.
* In the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboard_SetInitialDashboardStatetopic">ASPxDashboard.SetInitialDashboardState</a> event handler, the dashboard state is loaded from the cookies and applied to a dashboard.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-dashboard-save-dashboard-state-to-cookies&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-dashboard-save-dashboard-state-to-cookies&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
