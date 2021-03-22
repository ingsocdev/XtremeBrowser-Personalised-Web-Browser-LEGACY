<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XPad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XPad))
        Me.Navigator = New System.Windows.Forms.TabControl()
        Me.SuspendLayout()
        '
        'Navigator
        '
        Me.Navigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Navigator.Location = New System.Drawing.Point(0, 0)
        Me.Navigator.Name = "Navigator"
        Me.Navigator.SelectedIndex = 0
        Me.Navigator.Size = New System.Drawing.Size(693, 408)
        Me.Navigator.TabIndex = 0
        '
        'XPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(693, 408)
        Me.Controls.Add(Me.Navigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "XPad"
        Me.Text = "XPad"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Navigator As System.Windows.Forms.TabControl
End Class
