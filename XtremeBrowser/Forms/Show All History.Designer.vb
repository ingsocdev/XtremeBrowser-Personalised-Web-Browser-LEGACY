<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_All_History
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
        Me.Delete_Selected_Item_btn = New System.Windows.Forms.Button()
        Me.History_List_Box = New System.Windows.Forms.ListBox()
        Me.Clear_History_btn = New System.Windows.Forms.Button()
        Me.Ok_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Delete_Selected_Item_btn
        '
        Me.Delete_Selected_Item_btn.Location = New System.Drawing.Point(12, 299)
        Me.Delete_Selected_Item_btn.Name = "Delete_Selected_Item_btn"
        Me.Delete_Selected_Item_btn.Size = New System.Drawing.Size(114, 23)
        Me.Delete_Selected_Item_btn.TabIndex = 0
        Me.Delete_Selected_Item_btn.Text = "Delete Selected Item"
        Me.Delete_Selected_Item_btn.UseVisualStyleBackColor = True
        '
        'History_List_Box
        '
        Me.History_List_Box.FormattingEnabled = True
        Me.History_List_Box.Location = New System.Drawing.Point(12, 12)
        Me.History_List_Box.Name = "History_List_Box"
        Me.History_List_Box.Size = New System.Drawing.Size(566, 277)
        Me.History_List_Box.TabIndex = 1
        '
        'Clear_History_btn
        '
        Me.Clear_History_btn.Location = New System.Drawing.Point(132, 299)
        Me.Clear_History_btn.Name = "Clear_History_btn"
        Me.Clear_History_btn.Size = New System.Drawing.Size(75, 23)
        Me.Clear_History_btn.TabIndex = 2
        Me.Clear_History_btn.Text = "Clear History"
        Me.Clear_History_btn.UseVisualStyleBackColor = True
        '
        'Ok_btn
        '
        Me.Ok_btn.Location = New System.Drawing.Point(503, 299)
        Me.Ok_btn.Name = "Ok_btn"
        Me.Ok_btn.Size = New System.Drawing.Size(75, 23)
        Me.Ok_btn.TabIndex = 3
        Me.Ok_btn.Text = "Ok"
        Me.Ok_btn.UseVisualStyleBackColor = True
        '
        'Show_All_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 334)
        Me.Controls.Add(Me.Ok_btn)
        Me.Controls.Add(Me.Clear_History_btn)
        Me.Controls.Add(Me.History_List_Box)
        Me.Controls.Add(Me.Delete_Selected_Item_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Show_All_History"
        Me.Text = " Show All History"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Delete_Selected_Item_btn As System.Windows.Forms.Button
    Friend WithEvents History_List_Box As System.Windows.Forms.ListBox
    Friend WithEvents Clear_History_btn As System.Windows.Forms.Button
    Friend WithEvents Ok_btn As System.Windows.Forms.Button
End Class
