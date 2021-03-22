<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XPad_Start_Page
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XPad_Start_Page))
        Me.Close_Btn = New System.Windows.Forms.Button()
        Me.Open_Document_Link_Label = New System.Windows.Forms.LinkLabel()
        Me.New_Document_Link_Label = New System.Windows.Forms.LinkLabel()
        Me.What_To_Do_Group_Box = New System.Windows.Forms.GroupBox()
        Me.Open = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.What_To_Do_Group_Box.SuspendLayout()
        Me.SuspendLayout()
        '
        'Close_Btn
        '
        Me.Close_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_Btn.Location = New System.Drawing.Point(333, 246)
        Me.Close_Btn.Name = "Close_Btn"
        Me.Close_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Close_Btn.TabIndex = 5
        Me.Close_Btn.Text = "Close"
        Me.Close_Btn.UseVisualStyleBackColor = True
        '
        'Open_Document_Link_Label
        '
        Me.Open_Document_Link_Label.AutoSize = True
        Me.Open_Document_Link_Label.Location = New System.Drawing.Point(6, 40)
        Me.Open_Document_Link_Label.Name = "Open_Document_Link_Label"
        Me.Open_Document_Link_Label.Size = New System.Drawing.Size(85, 13)
        Me.Open_Document_Link_Label.TabIndex = 1
        Me.Open_Document_Link_Label.TabStop = True
        Me.Open_Document_Link_Label.Text = "Open Document"
        '
        'New_Document_Link_Label
        '
        Me.New_Document_Link_Label.AutoSize = True
        Me.New_Document_Link_Label.Location = New System.Drawing.Point(6, 16)
        Me.New_Document_Link_Label.Name = "New_Document_Link_Label"
        Me.New_Document_Link_Label.Size = New System.Drawing.Size(81, 13)
        Me.New_Document_Link_Label.TabIndex = 0
        Me.New_Document_Link_Label.TabStop = True
        Me.New_Document_Link_Label.Text = "New Document"
        '
        'What_To_Do_Group_Box
        '
        Me.What_To_Do_Group_Box.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.What_To_Do_Group_Box.Controls.Add(Me.Open_Document_Link_Label)
        Me.What_To_Do_Group_Box.Controls.Add(Me.New_Document_Link_Label)
        Me.What_To_Do_Group_Box.Location = New System.Drawing.Point(3, 196)
        Me.What_To_Do_Group_Box.Name = "What_To_Do_Group_Box"
        Me.What_To_Do_Group_Box.Size = New System.Drawing.Size(173, 73)
        Me.What_To_Do_Group_Box.TabIndex = 4
        Me.What_To_Do_Group_Box.TabStop = False
        Me.What_To_Do_Group_Box.Text = "What To Do"
        '
        'Open
        '
        Me.Open.FileName = "Open"
        Me.Open.Filter = "Text (*.txt)|*.txt|All Files (*.*)|*.*"
        Me.Open.Title = "Open Document"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 184)
        Me.Panel1.TabIndex = 3
        '
        'XPad_Start_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.Close_Btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.What_To_Do_Group_Box)
        Me.Name = "XPad_Start_Page"
        Me.Size = New System.Drawing.Size(412, 275)
        Me.What_To_Do_Group_Box.ResumeLayout(False)
        Me.What_To_Do_Group_Box.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Close_Btn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Open_Document_Link_Label As System.Windows.Forms.LinkLabel
    Friend WithEvents New_Document_Link_Label As System.Windows.Forms.LinkLabel
    Friend WithEvents What_To_Do_Group_Box As System.Windows.Forms.GroupBox
    Friend WithEvents Open As System.Windows.Forms.OpenFileDialog

End Class
