Public Class Unlock

    Private Sub Unlock_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit_btn.Click
        Dim pass As String = Password_Input_Field.Text
        If Password_Input_Field.Text = ("") Then
            MsgBox("No password is entered.", MsgBoxStyle.Critical)
        ElseIf My.Settings.User_Name.Contains(Current_User) And My.Settings.Password.Contains(pass) Then
            MsgBox("Browser unlocked, Welcome back " & Current_User & ".")
            XtremeBrowser.Show()
            Me.Close()
        Else
            MsgBox("Incorrect Password", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Unlock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = ("Browser locked by " & Current_User & " at " & Current_Time)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Leave_Message_btn.Click
        Leave_Message.Show()
    End Sub

    Private Sub Password_Input_Field_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Password_Input_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Submit_btn.PerformClick()
        End If
    End Sub

End Class