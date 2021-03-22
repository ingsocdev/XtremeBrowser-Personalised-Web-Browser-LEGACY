Imports System.Runtime.InteropServices
Public Class About
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
    End Structure

    <DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function

    Private Sub Ok_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_Button.Click
        Me.Close()
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim margins As MARGINS = New MARGINS
        margins.cxLeftWidth = 2
        margins.cxRightWidth = 2
        margins.cyTopHeight = 23
        margins.cyBottomHeight = 2
        Dim hwnd As IntPtr = Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        XtremeBrowser.AddTab("http://www.xtremetech.co.cc/donate.html", XtremeBrowser.TabControl1.Tag)
    End Sub
End Class
