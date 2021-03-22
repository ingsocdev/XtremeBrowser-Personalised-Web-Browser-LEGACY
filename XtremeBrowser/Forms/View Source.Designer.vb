<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Source
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Source))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Ok_Button = New System.Windows.Forms.Button()
        Me.View_Source_Rich_Text_Box = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Ok_Button)
        Me.Panel1.Controls.Add(Me.View_Source_Rich_Text_Box)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 358)
        Me.Panel1.TabIndex = 0
        '
        'Ok_Button
        '
        Me.Ok_Button.Location = New System.Drawing.Point(200, 322)
        Me.Ok_Button.Name = "Ok_Button"
        Me.Ok_Button.Size = New System.Drawing.Size(75, 23)
        Me.Ok_Button.TabIndex = 6
        Me.Ok_Button.Text = "Ok"
        Me.Ok_Button.UseVisualStyleBackColor = True
        '
        'View_Source_Rich_Text_Box
        '
        Me.View_Source_Rich_Text_Box.Location = New System.Drawing.Point(0, 0)
        Me.View_Source_Rich_Text_Box.Name = "View_Source_Rich_Text_Box"
        Me.View_Source_Rich_Text_Box.Size = New System.Drawing.Size(485, 316)
        Me.View_Source_Rich_Text_Box.TabIndex = 7
        Me.View_Source_Rich_Text_Box.Text = ""
        '
        'View_Source
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(485, 378)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "View_Source"
        Me.Text = "View Source"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Ok_Button As System.Windows.Forms.Button
    Friend WithEvents View_Source_Rich_Text_Box As System.Windows.Forms.RichTextBox
End Class
