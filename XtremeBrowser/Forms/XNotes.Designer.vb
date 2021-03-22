<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XNotes))
        Me.XNotes_Rich_Text_Box = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Ok_btn = New System.Windows.Forms.Button()
        Me.Save_Note_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XNotes_Rich_Text_Box
        '
        Me.XNotes_Rich_Text_Box.Location = New System.Drawing.Point(0, 0)
        Me.XNotes_Rich_Text_Box.Name = "XNotes_Rich_Text_Box"
        Me.XNotes_Rich_Text_Box.Size = New System.Drawing.Size(485, 316)
        Me.XNotes_Rich_Text_Box.TabIndex = 7
        Me.XNotes_Rich_Text_Box.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Ok_btn)
        Me.Panel1.Controls.Add(Me.Save_Note_btn)
        Me.Panel1.Controls.Add(Me.XNotes_Rich_Text_Box)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 358)
        Me.Panel1.TabIndex = 1
        '
        'Ok_btn
        '
        Me.Ok_btn.Location = New System.Drawing.Point(248, 322)
        Me.Ok_btn.Name = "Ok_btn"
        Me.Ok_btn.Size = New System.Drawing.Size(75, 23)
        Me.Ok_btn.TabIndex = 8
        Me.Ok_btn.Text = "Ok"
        Me.Ok_btn.UseVisualStyleBackColor = True
        '
        'Save_Note_btn
        '
        Me.Save_Note_btn.Location = New System.Drawing.Point(167, 323)
        Me.Save_Note_btn.Name = "Save_Note_btn"
        Me.Save_Note_btn.Size = New System.Drawing.Size(75, 23)
        Me.Save_Note_btn.TabIndex = 6
        Me.Save_Note_btn.Text = "Save Note"
        Me.Save_Note_btn.UseVisualStyleBackColor = True
        '
        'XNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(485, 378)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "XNotes"
        Me.Text = "XNotes"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XNotes_Rich_Text_Box As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Save_Note_btn As System.Windows.Forms.Button
    Friend WithEvents Ok_btn As System.Windows.Forms.Button
End Class
