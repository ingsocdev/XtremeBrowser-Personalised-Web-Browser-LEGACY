Imports System.Runtime.InteropServices
Public Class XPad_SubForm
    Friend Sub NewDoc()
        Dim XPad As New XPad_Controls
        Navigator.TabPages.Add("Document")
        XPad.Name = "Text Editor"
        XPad.Dock = DockStyle.Fill
        Navigator.SelectTab(Navigator.TabPages.Count - 1)
        Navigator.SelectedTab.Controls.Add(XPad)
    End Sub

    Friend Sub OpenDoc(ByVal FN As String, ByVal SFN As String)
        Dim XPad As New XPad_Controls
        Dim Reader As New System.IO.StreamReader(FN)
        Navigator.TabPages.Add(SFN)
        XPad.Name = "Text Editor"
        XPad.Dock = DockStyle.Fill
        XPad.Document.Text = Reader.ReadToEnd
        Reader.Close()
        Navigator.SelectTab(Navigator.TabPages.Count - 1)
        Navigator.SelectedTab.Controls.Add(XPad)
    End Sub

    Friend Sub StartUp()
        Dim XPad_Start_Page As New XPad_Start_Page
        Navigator.TabPages.Add("Start Page")
        XPad_Start_Page.Name = "SP"
        XPad_Start_Page.Dock = DockStyle.Fill
        Navigator.SelectTab(Navigator.TabPages.Count - 1)
        Navigator.SelectedTab.Controls.Add(XPad_Start_Page)
    End Sub

    Friend Sub NewWindow(ByVal Text As String, ByVal Title As String)
        Dim XPad_SubForm As New XPad_SubForm
        Dim XPad As New XPad_Controls
        XPad_SubForm.Navigator.TabPages.Add(Title)
        XPad_SubForm.Text = "Text Editor Pro - " + Title
        XPad.Name = "Text Editor"
        XPad.Dock = DockStyle.Fill
        XPad.Document.Text = Text
        XPad_SubForm.Navigator.SelectedTab.Controls.Add(XPad)
        CloseTab()
        XPad_SubForm.Show()
    End Sub

    Friend Sub CloseTab()
        Try
            If Navigator.TabPages.Count = 1 Then : My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            Else
                Navigator.TabPages.RemoveAt(Navigator.SelectedIndex) : Navigator.SelectTab(Navigator.TabPages.Count - 1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Text Editor Pro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Navigator_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Navigator.SelectedIndexChanged
        Me.Text = "Text Editor Pro - " + Navigator.SelectedTab.Text
    End Sub
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
    End Structure
    <DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function
    Private Sub XPad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StartUp()
        Dim margins As MARGINS = New MARGINS
        margins.cxLeftWidth = 2
        margins.cxRightWidth = 2
        margins.cyTopHeight = 23
        margins.cyBottomHeight = 2
        Dim hwnd As IntPtr = Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
    End Sub
End Class