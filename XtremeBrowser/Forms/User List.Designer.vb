<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_List))
        Me.Ok_btn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Ok_btn
        '
        Me.Ok_btn.Location = New System.Drawing.Point(151, 178)
        Me.Ok_btn.Name = "Ok_btn"
        Me.Ok_btn.Size = New System.Drawing.Size(75, 23)
        Me.Ok_btn.TabIndex = 0
        Me.Ok_btn.Text = "Ok"
        Me.Ok_btn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(355, 160)
        Me.ListBox1.TabIndex = 1
        '
        'User_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 209)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Ok_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User_List"
        Me.Text = "User List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ok_btn As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
