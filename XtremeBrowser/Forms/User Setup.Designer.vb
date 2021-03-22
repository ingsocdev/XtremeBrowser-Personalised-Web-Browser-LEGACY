<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Setup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Setup))
        Me.Submit_btn = New System.Windows.Forms.Button()
        Me.User_Input_Field = New System.Windows.Forms.TextBox()
        Me.Password_Input_Field = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Submit_btn
        '
        Me.Submit_btn.Location = New System.Drawing.Point(178, 58)
        Me.Submit_btn.Name = "Submit_btn"
        Me.Submit_btn.Size = New System.Drawing.Size(75, 23)
        Me.Submit_btn.TabIndex = 0
        Me.Submit_btn.Text = "Submit"
        Me.Submit_btn.UseVisualStyleBackColor = True
        '
        'User_Input_Field
        '
        Me.User_Input_Field.Location = New System.Drawing.Point(76, 6)
        Me.User_Input_Field.Name = "User_Input_Field"
        Me.User_Input_Field.Size = New System.Drawing.Size(303, 20)
        Me.User_Input_Field.TabIndex = 1
        '
        'Password_Input_Field
        '
        Me.Password_Input_Field.Location = New System.Drawing.Point(76, 32)
        Me.Password_Input_Field.Name = "Password_Input_Field"
        Me.Password_Input_Field.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_Input_Field.Size = New System.Drawing.Size(303, 20)
        Me.Password_Input_Field.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password: "
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 63)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(33, 13)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Login"
        '
        'User_Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 87)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password_Input_Field)
        Me.Controls.Add(Me.User_Input_Field)
        Me.Controls.Add(Me.Submit_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "User_Setup"
        Me.Text = "User Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Submit_btn As System.Windows.Forms.Button
    Friend WithEvents User_Input_Field As System.Windows.Forms.TextBox
    Friend WithEvents Password_Input_Field As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel

End Class
