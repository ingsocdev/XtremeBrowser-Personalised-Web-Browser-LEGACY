<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XPad_Controls
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Document = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.File_Menu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.New_Window_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.New_Tab_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Tab_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.Open_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print_Preview_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.Edit_Menu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Undo_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.Redo_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip_Cut_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.Select_All_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Save = New System.Windows.Forms.SaveFileDialog()
        Me.Open = New System.Windows.Forms.OpenFileDialog()
        Me.Save_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.Find_Menu_Item = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Tab_btn = New System.Windows.Forms.ToolStripButton()
        Me.Remove_Tab_btn = New System.Windows.Forms.ToolStripButton()
        Me.New_Window_btn = New System.Windows.Forms.ToolStripButton()
        Me.Save_btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Bold_btn = New System.Windows.Forms.ToolStripButton()
        Me.Italic_btn = New System.Windows.Forms.ToolStripButton()
        Me.Underline_btn = New System.Windows.Forms.ToolStripButton()
        Me.Copy_btn = New System.Windows.Forms.ToolStripButton()
        Me.Paste_btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Document)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(457, 365)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(457, 416)
        Me.ToolStripContainer1.TabIndex = 4
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'Document
        '
        Me.Document.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Document.Location = New System.Drawing.Point(0, 0)
        Me.Document.Name = "Document"
        Me.Document.Size = New System.Drawing.Size(457, 365)
        Me.Document.TabIndex = 0
        Me.Document.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File_Menu, Me.Edit_Menu, Me.FormatToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(457, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'File_Menu
        '
        Me.File_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.File_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.New_Window_Menu_Item, Me.New_Tab_Menu_Item, Me.Remove_Tab_Menu_Item, Me.ToolStripSeparator14, Me.Open_Menu_Item, Me.Save_Menu_Item, Me.Print_Preview_Menu_Item, Me.Print_Menu_Item})
        Me.File_Menu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.File_Menu.Name = "File_Menu"
        Me.File_Menu.Size = New System.Drawing.Size(38, 19)
        Me.File_Menu.Text = "File"
        Me.File_Menu.ToolTipText = "File"
        '
        'New_Window_Menu_Item
        '
        Me.New_Window_Menu_Item.Name = "New_Window_Menu_Item"
        Me.New_Window_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.New_Window_Menu_Item.Size = New System.Drawing.Size(188, 22)
        Me.New_Window_Menu_Item.Text = "New Window"
        Me.New_Window_Menu_Item.ToolTipText = "New Window"
        '
        'New_Tab_Menu_Item
        '
        Me.New_Tab_Menu_Item.Name = "New_Tab_Menu_Item"
        Me.New_Tab_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.New_Tab_Menu_Item.Size = New System.Drawing.Size(188, 22)
        Me.New_Tab_Menu_Item.Text = "New Tab"
        Me.New_Tab_Menu_Item.ToolTipText = "New Tab"
        '
        'Remove_Tab_Menu_Item
        '
        Me.Remove_Tab_Menu_Item.Name = "Remove_Tab_Menu_Item"
        Me.Remove_Tab_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.Remove_Tab_Menu_Item.Size = New System.Drawing.Size(188, 22)
        Me.Remove_Tab_Menu_Item.Text = "Remove Tab"
        Me.Remove_Tab_Menu_Item.ToolTipText = "Remove Tab"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(185, 6)
        '
        'Open_Menu_Item
        '
        Me.Open_Menu_Item.Name = "Open_Menu_Item"
        Me.Open_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.Open_Menu_Item.Size = New System.Drawing.Size(188, 22)
        Me.Open_Menu_Item.Text = "Open"
        Me.Open_Menu_Item.ToolTipText = "Open"
        '
        'Print_Preview_Menu_Item
        '
        Me.Print_Preview_Menu_Item.Name = "Print_Preview_Menu_Item"
        Me.Print_Preview_Menu_Item.Size = New System.Drawing.Size(188, 22)
        Me.Print_Preview_Menu_Item.Text = "Print Preview"
        '
        'Print_Menu_Item
        '
        Me.Print_Menu_Item.Name = "Print_Menu_Item"
        Me.Print_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.Print_Menu_Item.Size = New System.Drawing.Size(188, 22)
        Me.Print_Menu_Item.Text = "Print"
        '
        'Edit_Menu
        '
        Me.Edit_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Edit_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Undo_Menu_Item, Me.Redo_Menu_Item, Me.ToolStripSeparator16, Me.ToolStrip_Cut_Menu_Item, Me.Copy_Menu_Item, Me.Paste_Menu_Item, Me.ToolStripSeparator17, Me.Select_All_Menu_Item, Me.ToolStripSeparator18, Me.Find_Menu_Item})
        Me.Edit_Menu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Edit_Menu.Name = "Edit_Menu"
        Me.Edit_Menu.Size = New System.Drawing.Size(40, 19)
        Me.Edit_Menu.Text = "Edit"
        Me.Edit_Menu.ToolTipText = "Edit"
        '
        'Undo_Menu_Item
        '
        Me.Undo_Menu_Item.Name = "Undo_Menu_Item"
        Me.Undo_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.Undo_Menu_Item.Size = New System.Drawing.Size(164, 22)
        Me.Undo_Menu_Item.Text = "Undo"
        '
        'Redo_Menu_Item
        '
        Me.Redo_Menu_Item.Name = "Redo_Menu_Item"
        Me.Redo_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.Redo_Menu_Item.Size = New System.Drawing.Size(164, 22)
        Me.Redo_Menu_Item.Text = "Redo"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStrip_Cut_Menu_Item
        '
        Me.ToolStrip_Cut_Menu_Item.Name = "ToolStrip_Cut_Menu_Item"
        Me.ToolStrip_Cut_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ToolStrip_Cut_Menu_Item.Size = New System.Drawing.Size(164, 22)
        Me.ToolStrip_Cut_Menu_Item.Text = "Cut"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(161, 6)
        '
        'Select_All_Menu_Item
        '
        Me.Select_All_Menu_Item.Name = "Select_All_Menu_Item"
        Me.Select_All_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.Select_All_Menu_Item.Size = New System.Drawing.Size(164, 22)
        Me.Select_All_Menu_Item.Text = "Select All"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(161, 6)
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 22)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add_Tab_btn, Me.Remove_Tab_btn, Me.New_Window_btn, Me.Save_btn, Me.ToolStripButton1, Me.Bold_btn, Me.Italic_btn, Me.Underline_btn, Me.Copy_btn, Me.Paste_btn})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 26)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(233, 25)
        Me.ToolStrip1.TabIndex = 1
        '
        'Save
        '
        Me.Save.Filter = "Text (*.txt)|*.txt|All Files (*.*)|*.*"
        Me.Save.Title = "Save Document"
        '
        'Open
        '
        Me.Open.Filter = "Text (*.txt)|*.txt|All Files (*.*)|*.*"
        Me.Open.Title = "Open Document"
        '
        'Save_Menu_Item
        '
        Me.Save_Menu_Item.Image = Global.XtremeBrowser.My.Resources.Resources.Save_btn
        Me.Save_Menu_Item.Name = "Save_Menu_Item"
        Me.Save_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.Save_Menu_Item.Size = New System.Drawing.Size(188, 22)
        Me.Save_Menu_Item.Text = "Save"
        '
        'Copy_Menu_Item
        '
        Me.Copy_Menu_Item.Image = Global.XtremeBrowser.My.Resources.Resources.Copy_btn
        Me.Copy_Menu_Item.Name = "Copy_Menu_Item"
        Me.Copy_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Copy_Menu_Item.Size = New System.Drawing.Size(164, 22)
        Me.Copy_Menu_Item.Text = "Copy"
        '
        'Paste_Menu_Item
        '
        Me.Paste_Menu_Item.Image = Global.XtremeBrowser.My.Resources.Resources.Paste_btn
        Me.Paste_Menu_Item.Name = "Paste_Menu_Item"
        Me.Paste_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.Paste_Menu_Item.Size = New System.Drawing.Size(164, 22)
        Me.Paste_Menu_Item.Text = "Paste"
        '
        'Find_Menu_Item
        '
        Me.Find_Menu_Item.Image = Global.XtremeBrowser.My.Resources.Resources.Page_Search_btn
        Me.Find_Menu_Item.Name = "Find_Menu_Item"
        Me.Find_Menu_Item.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.Find_Menu_Item.Size = New System.Drawing.Size(164, 22)
        Me.Find_Menu_Item.Text = "Find"
        '
        'Add_Tab_btn
        '
        Me.Add_Tab_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Add_Tab_btn.Image = Global.XtremeBrowser.My.Resources.Resources.Add_Tab_btn
        Me.Add_Tab_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Add_Tab_btn.Name = "Add_Tab_btn"
        Me.Add_Tab_btn.Size = New System.Drawing.Size(23, 22)
        Me.Add_Tab_btn.ToolTipText = "Add Tab"
        '
        'Remove_Tab_btn
        '
        Me.Remove_Tab_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Remove_Tab_btn.Image = Global.XtremeBrowser.My.Resources.Resources.Remove_Tab_btn
        Me.Remove_Tab_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Remove_Tab_btn.Name = "Remove_Tab_btn"
        Me.Remove_Tab_btn.Size = New System.Drawing.Size(23, 22)
        Me.Remove_Tab_btn.ToolTipText = "Remove Tab"
        '
        'New_Window_btn
        '
        Me.New_Window_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.New_Window_btn.Image = Global.XtremeBrowser.My.Resources.Resources.New_Window_btn
        Me.New_Window_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.New_Window_btn.Name = "New_Window_btn"
        Me.New_Window_btn.Size = New System.Drawing.Size(23, 22)
        Me.New_Window_btn.ToolTipText = "New Window"
        '
        'Save_btn
        '
        Me.Save_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Save_btn.Image = Global.XtremeBrowser.My.Resources.Resources.Save_btn
        Me.Save_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(23, 22)
        Me.Save_btn.ToolTipText = "Save"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.XtremeBrowser.My.Resources.Resources.Page_Search_btn
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.ToolTipText = "Search"
        '
        'Bold_btn
        '
        Me.Bold_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bold_btn.Image = Global.XtremeBrowser.My.Resources.Resources.Bold_btn
        Me.Bold_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bold_btn.Name = "Bold_btn"
        Me.Bold_btn.Size = New System.Drawing.Size(23, 22)
        Me.Bold_btn.Text = "ToolStripButton2"
        Me.Bold_btn.ToolTipText = "Bold"
        '
        'Italic_btn
        '
        Me.Italic_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Italic_btn.Image = Global.XtremeBrowser.My.Resources.Resources.Italic_btn
        Me.Italic_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Italic_btn.Name = "Italic_btn"
        Me.Italic_btn.Size = New System.Drawing.Size(23, 22)
        Me.Italic_btn.Text = "ToolStripButton3"
        Me.Italic_btn.ToolTipText = "Italic"
        '
        'Underline_btn
        '
        Me.Underline_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Underline_btn.Image = Global.XtremeBrowser.My.Resources.Resources.Underline_btn
        Me.Underline_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Underline_btn.Name = "Underline_btn"
        Me.Underline_btn.Size = New System.Drawing.Size(23, 22)
        Me.Underline_btn.Text = "ToolStripButton2"
        Me.Underline_btn.ToolTipText = "Underline"
        '
        'Copy_btn
        '
        Me.Copy_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Copy_btn.Image = Global.XtremeBrowser.My.Resources.Resources.Copy_btn
        Me.Copy_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Copy_btn.Name = "Copy_btn"
        Me.Copy_btn.Size = New System.Drawing.Size(23, 22)
        Me.Copy_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.Copy_btn.ToolTipText = "Copy"
        '
        'Paste_btn
        '
        Me.Paste_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Paste_btn.Image = Global.XtremeBrowser.My.Resources.Resources.Paste_btn
        Me.Paste_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Paste_btn.Name = "Paste_btn"
        Me.Paste_btn.Size = New System.Drawing.Size(23, 22)
        Me.Paste_btn.ToolTipText = "Paste"
        '
        'XPad_Controls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "XPad_Controls"
        Me.Size = New System.Drawing.Size(457, 416)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents File_Menu As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents New_Window_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents New_Tab_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Remove_Tab_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Open_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Save_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print_Preview_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Edit_Menu As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Undo_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Redo_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip_Cut_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Copy_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Paste_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Select_All_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Find_Menu_Item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Open As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Document As System.Windows.Forms.RichTextBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Add_Tab_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Remove_Tab_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents New_Window_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Save_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Bold_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Italic_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Underline_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Copy_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Paste_btn As System.Windows.Forms.ToolStripButton

End Class
