Imports System.Runtime.InteropServices
Public Class View_Source
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
    End Structure
    Private Sub View_Source_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = XtremeBrowser.TabControl1.SelectedTab.Tag
        Try
            View_Source_Rich_Text_Box.Text = Xtreme_Browser.DocumentText
            If Not XtremeBrowser.Navigation_box.Text.Contains(":\") Then
                Me.Text = ("Xtreme Browser User: " + Current_User + ", Source of: " + Xtreme_Browser.Url.ToString)
            Else
                Me.Text = ("Xtreme Browser User: " + Current_User + ", Source of: " + XtremeBrowser.Navigation_box.Text.ToString)
            End If
            Dim margins As MARGINS = New MARGINS
            margins.cxLeftWidth = 2
            margins.cxRightWidth = 2
            margins.cyTopHeight = 23
            margins.cyBottomHeight = 2
            Dim hwnd As IntPtr = Handle
            Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
        Catch ex As Exception
            MsgBox("An error occured. The error is as follows: " + ex.ToString)
        End Try
    End Sub
    <DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function

    Private Sub Ok_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_Button.Click
        Me.Close()
    End Sub
End Class
