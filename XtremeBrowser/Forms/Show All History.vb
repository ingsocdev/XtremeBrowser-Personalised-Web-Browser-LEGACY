Imports System.IO
Public Class Show_All_History

    Private Sub Show_All_History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ("Xtreme Browser User: " + Current_User + ", History")
        Try
            Dim sr_History As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "\History" + ".txt")
            While sr_History.EndOfStream = False
                History_List_Box.Items.Add(sr_History.ReadLine)
            End While
            sr_History.Close()
        Catch
            MsgBox("There was a problem opening the history configuration file")
        End Try
    End Sub

    Private Sub Ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_btn.Click
        Me.Close()
    End Sub

    Private Sub Clear_History_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_History_btn.Click
        Dim Confirm As Integer
        Confirm = MsgBox(Prompt:="Are you sure you would like to clear your history " + Current_User + ".", Buttons:=vbYesNo)
        If Confirm = vbYes Then
            If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "\History" + ".txt") Then
                Try
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath + "/Users/" + Current_User + "\History" + ".txt")
                    Dim sw_History As New StreamWriter(Application.StartupPath + "/Users/" + Current_User + "\History" + ".txt")
                    sw_History.Flush()
                    sw_History.Close()
                    XtremeBrowser.History_Menu.DropDownItems.Clear()
                    History_List_Box.Items.Clear()
                    MsgBox("History cleared at " + Current_Time + ".")
                Catch
                    MsgBox("There was a problem opening the history configuration file.")
                End Try
            Else
                XtremeBrowser.Recover()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_Selected_Item_btn.Click
        Dim Selected_Index As String = History_List_Box.SelectedIndex
        If History_List_Box.SelectedItem = Nothing Then
            MsgBox("No Item is selected")
        Else
            Try
                Dim Filepath As String = (Application.StartupPath + "/Users/" + Current_User + "\History" + ".txt")
                Dim Lines() As String = System.IO.File.ReadAllLines(Filepath)
                Lines(Selected_Index) = Nothing
                System.IO.File.WriteAllLines(Filepath, Lines)
                XtremeBrowser.History_Menu.DropDownItems.RemoveAt(Selected_Index + 5)
                History_List_Box.Items.RemoveAt(Selected_Index)
                Filepath = (Application.StartupPath + "/Users/" + Current_User + "\Document Title.txt")
                Lines = System.IO.File.ReadAllLines(Filepath)
                Lines(Selected_Index) = Nothing
                System.IO.File.WriteAllLines(Filepath, Lines)
                Dim History_Items As String
                For Each item In History_List_Box.Items
                    History_Items = History_Items + (item.ToString + vbNewLine)
                Next
                History_Items.Replace(vbNewLine,"")
                Dim sw_History As New StreamWriter(Application.StartupPath + "/Users/" + Current_User + "\History.txt")
                sw_History.WriteLine(History_Items)
                sw_History.Flush()
                sw_History.Close()

            Catch ex As Exception
                MsgBox("There was a problem opening the history configuration file." + ex.ToString)
            End Try
        End If
    End Sub
End Class