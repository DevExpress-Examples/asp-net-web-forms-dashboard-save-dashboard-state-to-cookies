Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System
Imports System.Web

Namespace WebDashboard_DashboardStateCookies

    Public Partial Class [Default]
        Inherits UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboard1_SetInitialDashboardState(ByVal sender As Object, ByVal e As SetInitialDashboardStateEventArgs)
            ' Requests the "dashboardState" cookie:
            Dim cookie As HttpCookie = Request.Cookies("dashboardState")
            If cookie IsNot Nothing Then
                Dim dashboardState As DashboardState = New DashboardState()
                ' Initializes a DevExpress.DashboardCommon.DashboardState object from the JSON state:
                dashboardState.LoadFromJson(HttpUtility.UrlDecode(cookie.Value))
                ' Applies the initial dashboard state if it exists in cookies:
                If Equals(e.DashboardId, "dashboard1") Then e.InitialState = dashboardState
            End If
        End Sub
    End Class
End Namespace
