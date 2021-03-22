<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leave_Message
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leave_Message))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password_Input_Field = New System.Windows.Forms.TextBox()
        Me.User_Input_Field = New System.Windows.Forms.TextBox()
        Me.Submit_btn = New System.Windows.Forms.Button()
        Me.Message_Input_Field = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Password: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Username:"
        '
        'Password_Input_Field
        '
        Me.Password_Input_Field.Location = New System.Drawing.Point(72, 31)
        Me.Password_Input_Field.Name = "Password_Input_Field"
        Me.Password_Input_Field.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_Input_Field.Size = New System.Drawing.Size(303, 20)
        Me.Password_Input_Field.TabIndex = 17
        '
        'User_Input_Field
        '
        Me.User_Input_Field.Location = New System.Drawing.Point(72, 5)
        Me.User_Input_Field.Name = "User_Input_Field"
        Me.User_Input_Field.Size = New System.Drawing.Size(303, 20)
        Me.User_Input_Field.TabIndex = 16
        '
        'Submit_btn
        '
        Me.Submit_btn.Location = New System.Drawing.Point(182, 112)
        Me.Submit_btn.Name = "Submit_btn"
        Me.Submit_btn.Size = New System.Drawing.Size(75, 23)
        Me.Submit_btn.TabIndex = 15
        Me.Submit_btn.Text = "Submit"
        Me.Submit_btn.UseVisualStyleBackColor = True
        '
        'Message_Input_Field
        '
        Me.Message_Input_Field.Location = New System.Drawing.Point(72, 57)
        Me.Message_Input_Field.Multiline = True
        Me.Message_Input_Field.Name = "Message_Input_Field"
        Me.Message_Input_Field.Size = New System.Drawing.Size(303, 49)
        Me.Message_Input_Field.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Message: "
        '
        'Leave_Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 146)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Message_Input_Field)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password_Input_Field)
        Me.Controls.Add(Me.User_Input_Field)
        Me.Controls.Add(Me.Submit_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Leave_Message"
        Me.Text = "Leave Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Password_Input_Field As System.Windows.Forms.TextBox
    Friend WithEvents User_Input_Field As System.Windows.Forms.TextBox
    Friend WithEvents Submit_btn As System.Windows.Forms.Button
    Friend WithEvents Message_Input_Field As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
