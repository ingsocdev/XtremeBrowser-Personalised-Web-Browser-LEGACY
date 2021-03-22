Public Class Remove_User

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

    Private Sub Submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit_btn.Click
        Dim user As String = User_Input_Field.Text
        Dim pass As String = Password_Input_Field.Text
        If My.Settings.User_Name.Contains(user) And My.Settings.Password.Contains(pass) Then
            User_Input_Field.Text = ("")
            Password_Input_Field.Text = ("")
            My.Settings.User_Name.Remove(user)
            My.Settings.Password.Remove(pass)
            My.Settings.Save()
            If IO.Directory.Exists(Application.StartupPath + "\Users\" + user) Then
                IO.Directory.Delete(Application.StartupPath.ToString + "/Users/" + user, True)
            End If
            MsgBox("User " + user + ", has been removed.", MsgBoxStyle.OkOnly)
            Login.Show()
            Me.Dispose()
        ElseIf User_Input_Field.Text = ("") Then
            MsgBox("No username was entered.", MsgBoxStyle.Critical)
        ElseIf Password_Input_Field.Text = ("") Then
            MsgBox("No password was entered.", MsgBoxStyle.Critical)
        ElseIf Not My.Settings.User_Name.Contains(user) And Not My.Settings.Password.Contains(pass) Then
            User_Input_Field.Text = ("")
            Password_Input_Field.Text = ("")
            MsgBox("User " + user + " does not exist.", MsgBoxStyle.Critical)
        Else
            User_Input_Field.Text = ("")
            Password_Input_Field.Text = ("")
            MsgBox("Incorrect username or password.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Remove_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class