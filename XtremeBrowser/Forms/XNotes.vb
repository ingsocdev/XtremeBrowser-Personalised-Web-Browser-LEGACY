Imports System.Runtime.InteropServices
Imports System.IO
Public Class XNotes
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
    End Structure
    <DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function
    Private Sub XNotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ("Xtreme Browser User: " + Current_User + ", XNotes")
        Dim margins As MARGINS = New MARGINS
        margins.cxLeftWidth = 2
        margins.cxRightWidth = 2
        margins.cyTopHeight = 23
        margins.cyBottomHeight = 2
        Dim hwnd As IntPtr = Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
        XNotes_Rich_Text_Box.Text = Current_User_Notes
    End Sub

    Private Sub Ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_btn.Click
        Me.Close()
    End Sub

    Private Sub Save_Note_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Note_btn.Click
        Try
            Current_User_Notes = ("")
            System.IO.File.Delete(Application.StartupPath + "/Users/" + Current_User + "\XNotes" + ".txt")
            Dim sw_XNotes As New StreamWriter(Application.StartupPath + "/Users/" + Current_User + "\XNotes" + ".txt", True)
            For Each line In XNotes_Rich_Text_Box.Lines
                sw_XNotes.WriteLine(line)
                Current_User_Notes = Current_User_Notes + (line + vbNewLine)
            Next
            sw_XNotes.Flush()
            sw_XNotes.Close()
            MsgBox("Notes Saved")
        Catch
            MsgBox("There was a problem writing to the XNotes configuration file.")
        End Try

    End Sub
End Class