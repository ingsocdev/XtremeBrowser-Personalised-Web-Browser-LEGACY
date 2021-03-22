Public Class XPad_Start_Page

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_Btn.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles New_Document_Link_Label.LinkClicked
        XPad.NewDoc()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Open_Document_Link_Label.LinkClicked
        Open.ShowDialog()
    End Sub

    Private Sub XPad_Start_Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Open_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Open.FileOk
        XPad.OpenDoc(Open.FileName, Open.SafeFileName)
    End Sub
End Class
