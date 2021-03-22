<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timed_Shutdown
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
        Me.Ok_btn = New System.Windows.Forms.Button()
        Me.Time_Input_Field = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Ok_btn
        '
        Me.Ok_btn.Location = New System.Drawing.Point(146, 38)
        Me.Ok_btn.Name = "Ok_btn"
        Me.Ok_btn.Size = New System.Drawing.Size(73, 23)
        Me.Ok_btn.TabIndex = 0
        Me.Ok_btn.Text = "Ok"
        Me.Ok_btn.UseVisualStyleBackColor = True
        '
        'Time_Input_Field
        '
        Me.Time_Input_Field.Location = New System.Drawing.Point(12, 12)
        Me.Time_Input_Field.Name = "Time_Input_Field"
        Me.Time_Input_Field.Size = New System.Drawing.Size(336, 20)
        Me.Time_Input_Field.TabIndex = 2
        '
        'Timed_Shutdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 69)
        Me.Controls.Add(Me.Time_Input_Field)
        Me.Controls.Add(Me.Ok_btn)
        Me.Name = "Timed_Shutdown"
        Me.Text = "Timed Shutdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ok_btn As System.Windows.Forms.Button
    Friend WithEvents Time_Input_Field As System.Windows.Forms.TextBox
End Class
