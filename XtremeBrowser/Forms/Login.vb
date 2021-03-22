Imports Microsoft.Win32
Public Class Login
  
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit_btn.Click
        Dim user As String = User_Input_Field.Text
        Dim pass As String = Password_Input_Field.Text
        If My.Settings.User_Name.Contains(user) And My.Settings.Password.Contains(pass) Then
            User_Input_Field.Text = ("")
            Password_Input_Field.Text = ("")
            MsgBox("Welcome back, " + user)
            Current_User = user
            Current_User_Password = pass
            XtremeBrowser.Show()
            Me.Close()
        ElseIf Not user = ("") And Not My.Settings.User_Name.Contains(user) And Not My.Settings.Password.Contains(pass) Then
            MsgBox("User " + user + " does not exist.", MsgBoxStyle.Critical)
        ElseIf user = ("") Then
            MsgBox("No username was entered")
        ElseIf pass = ("") Then
            MsgBox("No password was entered.")
        Else
            MsgBox("Incorrect username or password.", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Settings.First_Run = False
        User_Setup.Show()
        Me.Dispose()
    End Sub

    Private Sub User_Input_Field_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles User_Input_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Submit_btn.PerformClick()
        End If
    End Sub

    Private Sub Password_Input_Field_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Password_Input_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Submit_btn.PerformClick()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Remove_User.Show()
        Me.Dispose()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        User_List.Show()
    End Sub

    Private Sub Login_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

End Class
