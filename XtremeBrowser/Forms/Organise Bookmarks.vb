Imports System.IO

Public Class Organise_Bookmarks

    Private Sub Organise_Bookmarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ("Xtreme Browser User: " + Current_User + ", Bookmarks")
        Try
            Dim sr_Document_Title2 As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "\Document Title2" + ".txt")
            While sr_Document_Title2.EndOfStream = False
                Bookmarks_List_Box.Items.Add(sr_Document_Title2.ReadLine)
            End While
            sr_Document_Title2.Close()
        Catch
            MsgBox("There was a problem opening the document title2 configuration file")
        End Try
        Try
            Dim sr_Document_Title3 As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "\Document Title3" + ".txt")
            While sr_Document_Title3.EndOfStream = False
                Bookmarks_Bar_List_Box.Items.Add(sr_Document_Title3.ReadLine)
            End While
            sr_Document_Title3.Close()
        Catch
            MsgBox("There was a problem opening the document title3 bar configuration file")
        End Try
    End Sub

    Private Sub Delete_Selected_Item_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_Selected_Item_btn.Click
        Dim Selected_Index As String = Bookmarks_List_Box.SelectedIndex
        If Bookmarks_List_Box.SelectedItem = Nothing Then
            MsgBox("No Item is selected")
        Else
            Try
                Dim Filepath As String = (Application.StartupPath + "/Users/" + Current_User + "\Bookmarks" + ".txt")
                Dim Lines() As String = System.IO.File.ReadAllLines(Filepath)
                Lines(Selected_Index) = Nothing
                System.IO.File.WriteAllLines(Filepath, Lines)
                XtremeBrowser.Bookmarks_Menu.DropDownItems.RemoveAt(Selected_Index + 5)
                Bookmarks_List_Box.Items.RemoveAt(Selected_Index)
                Filepath = (Application.StartupPath + "/Users/" + Current_User + "\Document Title2" + ".txt")
                Lines = System.IO.File.ReadAllLines(Filepath)
                Lines(Selected_Index) = Nothing
                System.IO.File.WriteAllLines(Filepath, Lines)

            Catch
                MsgBox("There was a problem opening the bookmarks configuration file.")
            End Try
        End If
    End Sub

    Private Sub Clear_Bookmarks_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Bookmarks_btn.Click
        Dim Confirm As Integer
        Confirm = MsgBox(Prompt:="Are you sure you would like to clear your bookmarks " + Current_User + ".", Buttons:=vbYesNo)
        If Confirm = vbYes Then
            If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "\Bookmarks" + ".txt") Then
                Try
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath + "/Users/" + Current_User + "\Bookmarks" + ".txt")
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath + "/Users/" + Current_User + "\Document Title2" + ".txt")
                    Dim sw_Bookmarks As New StreamWriter(Application.StartupPath + "/Users/" + Current_User + "\Bookmarks" + ".txt")
                    sw_Bookmarks.Flush()
                    sw_Bookmarks.Close()
                    Dim sw_Document_Title2 As New StreamWriter(Application.StartupPath + "/Users/" + Current_User + "\Document Title2" + ".txt")
                    sw_Document_Title2.Flush()
                    sw_Document_Title2.Close()
                    XtremeBrowser.Bookmarks_Menu.DropDownItems.Clear()
                    MsgBox("Bookmarks cleared at " + Current_Time + ".")
                Catch ex As Exception
                    MsgBox("There was a problem opening the bookmarks configuration file." + ex.ToString)
                End Try
            Else
                XtremeBrowser.Recover()
            End If
        End If
    End Sub

    Private Sub Ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_btn.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_Selected_Item_btn2.Click

    End Sub

    Private Sub Ok_btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_btn2.Click
        Me.Close()
    End Sub

    Private Sub Clear_Bookmarks_btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Bookmarks_btn2.Click
        Dim Confirm As Integer
        Confirm = MsgBox(Prompt:="Are you sure you would like to clear your bookmarks " + Current_User + ".", Buttons:=vbYesNo)
        If Confirm = vbYes Then
            If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "\Bookmarks Bar" + ".txt") Then
                Try
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath + "/Users/" + Current_User + "\Bookmarks Bar" + ".txt")
                    Dim sw_Bookmarks_Bar As New StreamWriter(Application.StartupPath + "/Users/" + Current_User + "\Bookmarks Bar" + ".txt")
                    sw_Bookmarks_Bar.Flush()
                    sw_Bookmarks_Bar.Close()
                    XtremeBrowser.Bookmarks_Menu.DropDownItems.Clear()
                    Bookmarks_List_Box.Items.Clear()
                    MsgBox("Bookmarks Bar cleared at " + Current_Time + ".")
                Catch
                    MsgBox("There was a problem opening the bookmarks bar configuration file.")
                End Try
            Else
                XtremeBrowser.Recover()
            End If
        End If
    End Sub
End Class