Imports System.IO

Public Class User_Setup

    Private Sub User_Setup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.First_Run = True Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit_btn.Click
        Dim user As String = User_Input_Field.Text
        Dim pass As String = Password_Input_Field.Text
        If User_Input_Field.Text = ("") Then
            MsgBox("No username is entered.", MsgBoxStyle.Critical)
        ElseIf Password_Input_Field.Text = ("") Then
            MsgBox("No password is entered.", MsgBoxStyle.Critical)
        ElseIf My.Settings.User_Name.Contains(user) Then
            User_Input_Field.Text = ("")
            Password_Input_Field.Text = ("")
            MsgBox("Username " + User_Input_Field.Text + " already exists.", MsgBoxStyle.Critical)
        Else
            If IO.Directory.Exists("/Users") Then
                Try
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/Users/" + user)
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/Users/" + user + "/Downloads")
                    Dim sw_Bookmarks As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Bookmarks" + ".txt")
                    sw_Bookmarks.Flush()
                    sw_Bookmarks.Close()
                    Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\History" + ".txt")
                    sw_History.Flush()
                    sw_History.Close()
                    Dim sw_Homepage As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Homepage" + ".txt")
                    sw_Homepage.Write("http://www.xtremetech.co.cc")
                    sw_Homepage.Flush()
                    sw_Homepage.Close()
                    Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Theme" + ".txt")
                    sw_Theme.Write("Trentacinque")
                    sw_Theme.Flush()
                    sw_Theme.Close()
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Search Engine" + ".txt")
                    sw_Search_Engine.Write("Google")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Dim sw_Filter As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Filter" + ".txt")
                    sw_Filter.WriteLine("False")
                    sw_Filter.Flush()
                    sw_Filter.Close()
                    Dim sw_Private_Browsing As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Private Browsing" + ".txt")
                    sw_Private_Browsing.WriteLine("False")
                    sw_Private_Browsing.Flush()
                    sw_Private_Browsing.Close()
                    Dim sw_Clear_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Clear History" + ".txt")
                    sw_Clear_History.WriteLine("False")
                    sw_Clear_History.Flush()
                    sw_Clear_History.Close()
                    Dim sw_Downloads_Path As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Downloads Path" + ".txt")
                    sw_Downloads_Path.WriteLine("C:/" + "/Users/" + My.User.Name + "\Downloads")
                    sw_Downloads_Path.Flush()
                    sw_Downloads_Path.Close()
                    Dim sw_Bookmarks_Bar As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Bookmarks Bar" + ".txt")
                    sw_Bookmarks_Bar.WriteLine("http://www.xtremetech.co.cc")
                    sw_Bookmarks_Bar.Flush()
                    sw_Bookmarks_Bar.Close()
                    Dim sw_XNotes As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\XNotes" + ".txt")
                    sw_XNotes.Flush()
                    sw_XNotes.Close()
                    Dim sw_Document_Title As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Document Title" + ".txt")
                    sw_Document_Title.Flush()
                    sw_Document_Title.Close()
                    Dim sw_Document_Title2 As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Document Title2" + ".txt")
                    sw_Document_Title2.Flush()
                    sw_Document_Title2.Close()
                    Dim sw_Document_Title3 As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Document Title3" + ".txt")
                    sw_Document_Title3.Flush()
                    sw_Document_Title3.Close()
                Catch ex As Exception
                    MsgBox("An error occured creating the user configuration files.")
                    Me.Close()
                End Try

            Else
                Try
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/Users/" + user)
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/Users/" + user + "/Downloads")
                    Dim sw_Bookmarks As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Bookmarks" + ".txt")
                    sw_Bookmarks.Flush()
                    sw_Bookmarks.Close()
                    Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\History" + ".txt")
                    sw_History.Flush()
                    sw_History.Close()
                    Dim sw_Homepage As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Homepage" + ".txt")
                    sw_Homepage.Write("http://www.xtremetech.co.cc")
                    sw_Homepage.Flush()
                    sw_Homepage.Close()
                    Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Theme" + ".txt")
                    sw_Theme.Write("Default")
                    sw_Theme.Flush()
                    sw_Theme.Close()
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Search Engine" + ".txt")
                    sw_Search_Engine.Write("Google")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Dim sw_Filter As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Filter" + ".txt")
                    sw_Filter.WriteLine("False")
                    sw_Filter.Flush()
                    sw_Filter.Close()
                    Dim sw_Private_Browsing As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Private Browsing" + ".txt")
                    sw_Private_Browsing.WriteLine("False")
                    sw_Private_Browsing.Flush()
                    sw_Private_Browsing.Close()
                    Dim sw_Clear_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Clear History" + ".txt")
                    sw_Clear_History.WriteLine("False")
                    sw_Clear_History.Flush()
                    sw_Clear_History.Close()
                    Dim sw_Downloads As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "/Downloads")
                    sw_Downloads.Flush()
                    sw_Downloads.Close()
                    Dim sw_Downloads_Path As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Downloads Path" + ".txt")
                    sw_Downloads_Path.WriteLine("C:/" + "/Users/" + My.User.Name + "\Downloads")
                    sw_Downloads_Path.Flush()
                    sw_Downloads_Path.Close()
                    Dim sw_Bookmarks_Bar As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Bookmarks Bar" + ".txt")
                    sw_Bookmarks_Bar.WriteLine("http://www.xtremetech.co.cc")
                    sw_Bookmarks_Bar.Flush()
                    sw_Bookmarks_Bar.Close()
                    Dim sw_XNotes As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\XNotes" + ".txt")
                    sw_XNotes.Flush()
                    sw_XNotes.Close()
                    Dim sw_Document_Title As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Document Title" + ".txt")
                    sw_Document_Title.Flush()
                    sw_Document_Title.Close()
                    Dim sw_Document_Title2 As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Document Title2" + ".txt")
                    sw_Document_Title2.Flush()
                    sw_Document_Title2.Close()
                    Dim sw_Document_Title3 As New StreamWriter(Application.StartupPath.ToString + "/Users/" + user + "\Document Title2" + ".txt")
                    sw_Document_Title3.Flush()
                    sw_Document_Title3.Close()
                Catch ex As Exception
                    MsgBox("An error occured creating the user configuration files.")
                    Me.Close()
                End Try

            End If
            User_Input_Field.Text = ("")
            Password_Input_Field.Text = ("")
            MsgBox("Welcome to Xtreme Browser, " + user)
            Current_User_Password = (pass)
            Current_User_Downloads_Path = ("C:/" + "/Users/" + My.User.Name + "\Downloads")
            My.Settings.User_Name.Add(user)
            My.Settings.Password.Add(pass)
            My.Settings.First_Run = False
            My.Settings.Save()
            Current_User = user
            Me.Close()
            XtremeBrowser.Show()
        End If
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
        Login.Show()
        Me.Close()
    End Sub

    Private Sub User_Setup_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

End Class

