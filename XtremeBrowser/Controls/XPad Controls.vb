
Public Class XPad_Controls

    Private Sub New_Tab_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_Tab_Menu_Item.Click
        XPad.NewDoc()
    End Sub

    Private Sub Remove_Tab_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove_Tab_Menu_Item.Click
        XPad.CloseTab()
    End Sub

    Private Sub New_Window_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_Window_Menu_Item.Click
        XPad.NewWindow(Document.Text, XPad.Navigator.SelectedTab.Text)
    End Sub

    Private Sub Save_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Menu_Item.Click
        Save.FileName = XPad.Navigator.SelectedTab.Text
        Save.ShowDialog()
    End Sub

    Private Sub Open_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Open_Menu_Item.Click
        Open.ShowDialog()
    End Sub

    Private Sub Open_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Open.FileOk
        XPad.OpenDoc(Open.FileName, Open.SafeFileName)
    End Sub

    Private Sub Save_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Save.FileOk
        Document.SaveFile(Save.FileName, RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub Undo_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Undo_Menu_Item.Click
        Document.Undo()
    End Sub

    Private Sub Redo_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Redo_Menu_Item.Click
        Document.Redo()
    End Sub

    Private Sub ToolStrip_Cut_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip_Cut_Menu_Item.Click
        Document.Cut()
    End Sub

    Private Sub Copy_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy_Menu_Item.Click
        Copy_btn.PerformClick()
    End Sub

    Private Sub Paste_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paste_Menu_Item.Click
        Paste_btn.PerformClick()
    End Sub

    Private Sub Select_All_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select_All_Menu_Item.Click
        Document.SelectAll()
    End Sub

    Private Sub Find_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find_Menu_Item.Click

    End Sub

    Private Sub Print_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print_Menu_Item.Click

    End Sub

    Private Sub Add_Tab_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Tab_btn.Click
        XPad.NewDoc()
    End Sub

    Private Sub Remove_Tab_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove_Tab_btn.Click
        XPad.CloseTab()
    End Sub

    Private Sub New_Window_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_Window_btn.Click
        XPad.NewWindow(Document.Text, XPad.Navigator.SelectedTab.Text)
    End Sub

    Private Sub Save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_btn.Click
        Save.ShowDialog()
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bold_btn.Click
        Document.SelectionFont = New Font(Document.Font, FontStyle.Bold)
    End Sub
    Private Sub Italic_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Document.SelectionFont = New Font(Document.Font, FontStyle.Italic)
    End Sub

    Private Sub Underline_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Underline_btn.Click
        Document.SelectionFont = New Font(Document.Font, FontStyle.Underline)
    End Sub

    Private Sub Copy_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy_btn.Click
        Document.Copy()
    End Sub

    Private Sub Paste_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paste_btn.Click
        Document.Paste()
    End Sub

    Private Sub Italic_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Italic_btn.Click

    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripContainer1.TopToolStripPanel.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class