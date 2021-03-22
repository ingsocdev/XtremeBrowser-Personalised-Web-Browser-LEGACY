Public Class Lock

    Private Sub Lock_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Lock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit_btn.Click
        Dim user As String = Current_User
        Dim pass As String = Password_Input_Field.Text
        If Password_Input_Field.Text = ("") Then
            MsgBox("You did not enter a password, " + Current_User + ".", MsgBoxStyle.Critical)
        ElseIf My.Settings.User_Name.Contains(user) = True And My.Settings.Password.Contains(pass) = True Then
            Password_Input_Field.Text = ("")
            MsgBox("Browser locked successfully by " & Current_User & " at " & Current_Time)
            XtremeBrowser.Hide()
            Unlock.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Password", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Password_Input_Field_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Password_Input_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Submit_btn.PerformClick()
        End If
    End Sub

End Class