<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password_Input_Field = New System.Windows.Forms.TextBox()
        Me.User_Input_Field = New System.Windows.Forms.TextBox()
        Me.Submit_btn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username:"
        '
        'Password_Input_Field
        '
        Me.Password_Input_Field.Location = New System.Drawing.Point(72, 31)
        Me.Password_Input_Field.Name = "Password_Input_Field"
        Me.Password_Input_Field.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_Input_Field.Size = New System.Drawing.Size(303, 20)
        Me.Password_Input_Field.TabIndex = 7
        '
        'User_Input_Field
        '
        Me.User_Input_Field.Location = New System.Drawing.Point(72, 5)
        Me.User_Input_Field.Name = "User_Input_Field"
        Me.User_Input_Field.Size = New System.Drawing.Size(303, 20)
        Me.User_Input_Field.TabIndex = 6
        '
        'Submit_btn
        '
        Me.Submit_btn.Location = New System.Drawing.Point(163, 57)
        Me.Submit_btn.Name = "Submit_btn"
        Me.Submit_btn.Size = New System.Drawing.Size(75, 23)
        Me.Submit_btn.TabIndex = 5
        Me.Submit_btn.Text = "Submit"
        Me.Submit_btn.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 62)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(51, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add User"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(69, 62)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(72, 13)
        Me.LinkLabel2.TabIndex = 11
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Remove User"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(322, 62)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(53, 13)
        Me.LinkLabel3.TabIndex = 15
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "List Users"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 84)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password_Input_Field)
        Me.Controls.Add(Me.User_Input_Field)
        Me.Controls.Add(Me.Submit_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Password_Input_Field As System.Windows.Forms.TextBox
    Friend WithEvents User_Input_Field As System.Windows.Forms.TextBox
    Friend WithEvents Submit_btn As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
End Class
