<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lock))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password_Input_Field = New System.Windows.Forms.TextBox()
        Me.Submit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Password: "
        '
        'Password_Input_Field
        '
        Me.Password_Input_Field.Location = New System.Drawing.Point(75, 6)
        Me.Password_Input_Field.Name = "Password_Input_Field"
        Me.Password_Input_Field.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_Input_Field.Size = New System.Drawing.Size(303, 20)
        Me.Password_Input_Field.TabIndex = 17
        '
        'Submit_btn
        '
        Me.Submit_btn.Location = New System.Drawing.Point(171, 32)
        Me.Submit_btn.Name = "Submit_btn"
        Me.Submit_btn.Size = New System.Drawing.Size(75, 23)
        Me.Submit_btn.TabIndex = 15
        Me.Submit_btn.Text = "Submit"
        Me.Submit_btn.UseVisualStyleBackColor = True
        '
        'Lock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 64)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password_Input_Field)
        Me.Controls.Add(Me.Submit_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Lock"
        Me.Text = "Lock Session"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Password_Input_Field As System.Windows.Forms.TextBox
    Friend WithEvents Submit_btn As System.Windows.Forms.Button
End Class
