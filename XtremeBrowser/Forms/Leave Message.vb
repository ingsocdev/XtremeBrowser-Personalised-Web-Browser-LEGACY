
Public Class Leave_Message

    Private Sub Leave_Message_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub User_Input_Field_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles User_Input_Field.KeyDown, Password_Input_Field.KeyDown, Message_Input_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Submit_btn.PerformClick()
        End If
    End Sub

    Public Sub Submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit_btn.Click
        Dim User As String = User_Input_Field.Text
        Dim Pass As String = Password_Input_Field.Text
        Current_Time = Now
        If User_Input_Field.Text = ("") Then
            MsgBox("No username is entered.", MsgBoxStyle.Critical)
        ElseIf Password_Input_Field.Text = ("") Then
            MsgBox("No password is entered.", MsgBoxStyle.Critical)
        ElseIf Message_Input_Field.Text = ("") Then
            MsgBox("No message is entered.", MsgBoxStyle.Critical)
        ElseIf User_Input_Field.Text.Contains(Current_User) Then
            MsgBox(Current_User + " is the current user logged in!", MsgBoxStyle.Critical)
        ElseIf My.Settings.User_Name.Contains(User) = True And My.Settings.Password.Contains(Pass) = True Then
            XtremeBrowser.Msg = (Message_Input_Field.Text)
            XtremeBrowser.Msg_User = (User_Input_Field.Text)
            User_Input_Field.Text = ("")
            Password_Input_Field.Text = ("")
            Message_Input_Field.Text = ("")
            MsgBox("Message left by " & User & " at " & Current_Time)
            Unlock.Leave_Message_btn.Visible = False
            Me.Dispose()
        Else
            MsgBox("Username or password is incorrect.", MsgBoxStyle.Critical)
        End If
    End Sub

End Class