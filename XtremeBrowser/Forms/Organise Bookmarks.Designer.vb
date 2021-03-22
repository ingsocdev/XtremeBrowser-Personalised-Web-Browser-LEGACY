<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Organise_Bookmarks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Organise_Bookmarks))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Menu_Tab_Page = New System.Windows.Forms.TabPage()
        Me.Ok_btn = New System.Windows.Forms.Button()
        Me.Clear_Bookmarks_btn = New System.Windows.Forms.Button()
        Me.Bookmarks_List_Box = New System.Windows.Forms.ListBox()
        Me.Delete_Selected_Item_btn = New System.Windows.Forms.Button()
        Me.Bar_Tab_Page = New System.Windows.Forms.TabPage()
        Me.Ok_btn2 = New System.Windows.Forms.Button()
        Me.Clear_Bookmarks_btn2 = New System.Windows.Forms.Button()
        Me.Bookmarks_Bar_List_Box = New System.Windows.Forms.ListBox()
        Me.Delete_Selected_Item_btn2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Menu_Tab_Page.SuspendLayout()
        Me.Bar_Tab_Page.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Menu_Tab_Page)
        Me.TabControl1.Controls.Add(Me.Bar_Tab_Page)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(580, 324)
        Me.TabControl1.TabIndex = 0
        '
        'Menu_Tab_Page
        '
        Me.Menu_Tab_Page.Controls.Add(Me.Ok_btn)
        Me.Menu_Tab_Page.Controls.Add(Me.Clear_Bookmarks_btn)
        Me.Menu_Tab_Page.Controls.Add(Me.Bookmarks_List_Box)
        Me.Menu_Tab_Page.Controls.Add(Me.Delete_Selected_Item_btn)
        Me.Menu_Tab_Page.Location = New System.Drawing.Point(4, 22)
        Me.Menu_Tab_Page.Name = "Menu_Tab_Page"
        Me.Menu_Tab_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Menu_Tab_Page.Size = New System.Drawing.Size(572, 298)
        Me.Menu_Tab_Page.TabIndex = 0
        Me.Menu_Tab_Page.Text = "Menu"
        Me.Menu_Tab_Page.UseVisualStyleBackColor = True
        '
        'Ok_btn
        '
        Me.Ok_btn.Location = New System.Drawing.Point(494, 265)
        Me.Ok_btn.Name = "Ok_btn"
        Me.Ok_btn.Size = New System.Drawing.Size(75, 23)
        Me.Ok_btn.TabIndex = 11
        Me.Ok_btn.Text = "Ok"
        Me.Ok_btn.UseVisualStyleBackColor = True
        '
        'Clear_Bookmarks_btn
        '
        Me.Clear_Bookmarks_btn.Location = New System.Drawing.Point(123, 265)
        Me.Clear_Bookmarks_btn.Name = "Clear_Bookmarks_btn"
        Me.Clear_Bookmarks_btn.Size = New System.Drawing.Size(105, 23)
        Me.Clear_Bookmarks_btn.TabIndex = 10
        Me.Clear_Bookmarks_btn.Text = "Clear Bookmarks"
        Me.Clear_Bookmarks_btn.UseVisualStyleBackColor = True
        '
        'Bookmarks_List_Box
        '
        Me.Bookmarks_List_Box.FormattingEnabled = True
        Me.Bookmarks_List_Box.Location = New System.Drawing.Point(6, 4)
        Me.Bookmarks_List_Box.Name = "Bookmarks_List_Box"
        Me.Bookmarks_List_Box.Size = New System.Drawing.Size(563, 251)
        Me.Bookmarks_List_Box.TabIndex = 9
        '
        'Delete_Selected_Item_btn
        '
        Me.Delete_Selected_Item_btn.Location = New System.Drawing.Point(3, 265)
        Me.Delete_Selected_Item_btn.Name = "Delete_Selected_Item_btn"
        Me.Delete_Selected_Item_btn.Size = New System.Drawing.Size(114, 23)
        Me.Delete_Selected_Item_btn.TabIndex = 8
        Me.Delete_Selected_Item_btn.Text = "Delete Selected Item"
        Me.Delete_Selected_Item_btn.UseVisualStyleBackColor = True
        '
        'Bar_Tab_Page
        '
        Me.Bar_Tab_Page.Controls.Add(Me.Ok_btn2)
        Me.Bar_Tab_Page.Controls.Add(Me.Clear_Bookmarks_btn2)
        Me.Bar_Tab_Page.Controls.Add(Me.Bookmarks_Bar_List_Box)
        Me.Bar_Tab_Page.Controls.Add(Me.Delete_Selected_Item_btn2)
        Me.Bar_Tab_Page.Location = New System.Drawing.Point(4, 22)
        Me.Bar_Tab_Page.Name = "Bar_Tab_Page"
        Me.Bar_Tab_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Bar_Tab_Page.Size = New System.Drawing.Size(572, 298)
        Me.Bar_Tab_Page.TabIndex = 1
        Me.Bar_Tab_Page.Text = "Bar"
        Me.Bar_Tab_Page.UseVisualStyleBackColor = True
        '
        'Ok_btn2
        '
        Me.Ok_btn2.Location = New System.Drawing.Point(494, 268)
        Me.Ok_btn2.Name = "Ok_btn2"
        Me.Ok_btn2.Size = New System.Drawing.Size(75, 23)
        Me.Ok_btn2.TabIndex = 15
        Me.Ok_btn2.Text = "Ok"
        Me.Ok_btn2.UseVisualStyleBackColor = True
        '
        'Clear_Bookmarks_btn2
        '
        Me.Clear_Bookmarks_btn2.Location = New System.Drawing.Point(123, 268)
        Me.Clear_Bookmarks_btn2.Name = "Clear_Bookmarks_btn2"
        Me.Clear_Bookmarks_btn2.Size = New System.Drawing.Size(105, 23)
        Me.Clear_Bookmarks_btn2.TabIndex = 14
        Me.Clear_Bookmarks_btn2.Text = "Clear Bookmarks"
        Me.Clear_Bookmarks_btn2.UseVisualStyleBackColor = True
        '
        'Bookmarks_Bar_List_Box
        '
        Me.Bookmarks_Bar_List_Box.FormattingEnabled = True
        Me.Bookmarks_Bar_List_Box.Location = New System.Drawing.Point(6, 7)
        Me.Bookmarks_Bar_List_Box.Name = "Bookmarks_Bar_List_Box"
        Me.Bookmarks_Bar_List_Box.Size = New System.Drawing.Size(563, 251)
        Me.Bookmarks_Bar_List_Box.TabIndex = 13
        '
        'Delete_Selected_Item_btn2
        '
        Me.Delete_Selected_Item_btn2.Location = New System.Drawing.Point(3, 268)
        Me.Delete_Selected_Item_btn2.Name = "Delete_Selected_Item_btn2"
        Me.Delete_Selected_Item_btn2.Size = New System.Drawing.Size(114, 23)
        Me.Delete_Selected_Item_btn2.TabIndex = 12
        Me.Delete_Selected_Item_btn2.Text = "Delete Selected Item"
        Me.Delete_Selected_Item_btn2.UseVisualStyleBackColor = True
        '
        'Organise_Bookmarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 324)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Organise_Bookmarks"
        Me.Text = "Organise Bookmarks"
        Me.TabControl1.ResumeLayout(False)
        Me.Menu_Tab_Page.ResumeLayout(False)
        Me.Bar_Tab_Page.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Menu_Tab_Page As System.Windows.Forms.TabPage
    Friend WithEvents Ok_btn As System.Windows.Forms.Button
    Friend WithEvents Clear_Bookmarks_btn As System.Windows.Forms.Button
    Friend WithEvents Bookmarks_List_Box As System.Windows.Forms.ListBox
    Friend WithEvents Delete_Selected_Item_btn As System.Windows.Forms.Button
    Friend WithEvents Bar_Tab_Page As System.Windows.Forms.TabPage
    Friend WithEvents Ok_btn2 As System.Windows.Forms.Button
    Friend WithEvents Clear_Bookmarks_btn2 As System.Windows.Forms.Button
    Friend WithEvents Bookmarks_Bar_List_Box As System.Windows.Forms.ListBox
    Friend WithEvents Delete_Selected_Item_btn2 As System.Windows.Forms.Button
End Class
