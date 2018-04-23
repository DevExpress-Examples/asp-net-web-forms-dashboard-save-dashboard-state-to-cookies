Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System
Imports System.Web

Namespace WebDashboard_DashboardStateCookies
    Partial Public Class [Default]
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboard1_SetInitialDashboardState(ByVal sender As Object, ByVal e As SetInitialDashboardStateEventArgs)
            Dim cookie As HttpCookie = Request.Cookies("ASPxDashboardState")
            If cookie IsNot Nothing Then
                Dim dashboardState As New DashboardState()
                dashboardState.LoadFromJson(HttpUtility.UrlDecode(cookie.Value))
                If e.DashboardId = "dashboard1" Then
                    e.InitialState = dashboardState
                End If
            End If
        End Sub
    End Class
End Namespace