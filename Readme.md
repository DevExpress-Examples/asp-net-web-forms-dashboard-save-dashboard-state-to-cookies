# ASPxDashboard - How to save a dashboard state to cookies


<p>The sample illustrates how to save the current ASPxDashboard state (such as master filter or parameter values) to cookies on the client side and restore this state on the server side. The following API is used in this example

* The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboard_DashboardStateChangedtopic">ASPxClientDashboard.DashboardStateChanged</a> event is handled to obtain the current dashboard state.
* The <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientUtils_SetCookietopic">ASPxClientUtils.SetCookie</a> client-side method is used to save the dashboard state to cookies.
* In the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboard_SetInitialDashboardStatetopic">ASPxDashboard.SetInitialDashboardState</a> event handler, the dashboard state is loaded from the cookies and applied to a dashboard.</p>

<br/>


