Public Class User_List

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_btn.Click
        Me.Dispose()
    End Sub

    Private Sub User_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each item In My.Settings.User_Name
            ListBox1.Items.Add(item)
        Next
    End Sub
End Class