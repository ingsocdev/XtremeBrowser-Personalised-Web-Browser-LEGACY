<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downloads
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
        Me.lblspd = New System.Windows.Forms.Label()
        Me.lblsize = New System.Windows.Forms.Label()
        Me.lblsloc = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblpercent = New System.Windows.Forms.Label()
        Me.lblstat = New System.Windows.Forms.Label()
        Me.lbldownloading = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Save_Location_Text_Box = New System.Windows.Forms.TextBox()
        Me.Where_To_Save_Label = New System.Windows.Forms.Label()
        Me.Url_Text_Box = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Url_Label = New System.Windows.Forms.Label()
        Me.brws = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblspd
        '
        Me.lblspd.AutoSize = True
        Me.lblspd.Location = New System.Drawing.Point(7, 133)
        Me.lblspd.Name = "lblspd"
        Me.lblspd.Size = New System.Drawing.Size(44, 13)
        Me.lblspd.TabIndex = 27
        Me.lblspd.Text = "Speed :"
        '
        'lblsize
        '
        Me.lblsize.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblsize.AutoSize = True
        Me.lblsize.Location = New System.Drawing.Point(7, 118)
        Me.lblsize.Name = "lblsize"
        Me.lblsize.Size = New System.Drawing.Size(33, 13)
        Me.lblsize.TabIndex = 26
        Me.lblsize.Text = "Size :"
        '
        'lblsloc
        '
        Me.lblsloc.AutoSize = True
        Me.lblsloc.Location = New System.Drawing.Point(7, 103)
        Me.lblsloc.Name = "lblsloc"
        Me.lblsloc.Size = New System.Drawing.Size(50, 13)
        Me.lblsloc.TabIndex = 25
        Me.lblsloc.Text = "Save to :"
        '
        'lblpercent
        '
        Me.lblpercent.AutoSize = True
        Me.lblpercent.Location = New System.Drawing.Point(288, 189)
        Me.lblpercent.Name = "lblpercent"
        Me.lblpercent.Size = New System.Drawing.Size(21, 13)
        Me.lblpercent.TabIndex = 29
        Me.lblpercent.Text = "0%"
        '
        'lblstat
        '
        Me.lblstat.AutoSize = True
        Me.lblstat.Location = New System.Drawing.Point(7, 149)
        Me.lblstat.Name = "lblstat"
        Me.lblstat.Size = New System.Drawing.Size(43, 13)
        Me.lblstat.TabIndex = 28
        Me.lblstat.Text = "Status :"
        '
        'lbldownloading
        '
        Me.lbldownloading.AutoSize = True
        Me.lbldownloading.Location = New System.Drawing.Point(7, 88)
        Me.lbldownloading.Name = "lbldownloading"
        Me.lbldownloading.Size = New System.Drawing.Size(75, 13)
        Me.lbldownloading.TabIndex = 24
        Me.lbldownloading.Text = "Downloading :"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(7, 73)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(41, 13)
        Me.lblname.TabIndex = 23
        Me.lblname.Text = "Name :"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 184)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(272, 23)
        Me.ProgressBar1.TabIndex = 22
        '
        'Save_Location_Text_Box
        '
        Me.Save_Location_Text_Box.Location = New System.Drawing.Point(96, 33)
        Me.Save_Location_Text_Box.Name = "Save_Location_Text_Box"
        Me.Save_Location_Text_Box.Size = New System.Drawing.Size(331, 20)
        Me.Save_Location_Text_Box.TabIndex = 21
        '
        'Where_To_Save_Label
        '
        Me.Where_To_Save_Label.AutoSize = True
        Me.Where_To_Save_Label.Location = New System.Drawing.Point(7, 36)
        Me.Where_To_Save_Label.Name = "Where_To_Save_Label"
        Me.Where_To_Save_Label.Size = New System.Drawing.Size(83, 13)
        Me.Where_To_Save_Label.TabIndex = 19
        Me.Where_To_Save_Label.Text = "Where to save :"
        '
        'Url_Text_Box
        '
        Me.Url_Text_Box.Location = New System.Drawing.Point(39, 5)
        Me.Url_Text_Box.Name = "Url_Text_Box"
        Me.Url_Text_Box.Size = New System.Drawing.Size(420, 20)
        Me.Url_Text_Box.TabIndex = 20
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Title = "Where to save"
        '
        'Url_Label
        '
        Me.Url_Label.AutoSize = True
        Me.Url_Label.Location = New System.Drawing.Point(7, 8)
        Me.Url_Label.Name = "Url_Label"
        Me.Url_Label.Size = New System.Drawing.Size(26, 13)
        Me.Url_Label.TabIndex = 18
        Me.Url_Label.Text = "Url :"
        '
        'brws
        '
        Me.brws.Location = New System.Drawing.Point(433, 30)
        Me.brws.Name = "brws"
        Me.brws.Size = New System.Drawing.Size(26, 23)
        Me.brws.TabIndex = 17
        Me.brws.Text = "..."
        Me.brws.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(316, 180)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 30)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_download
        '
        Me.btn_download.Location = New System.Drawing.Point(397, 180)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(75, 30)
        Me.btn_download.TabIndex = 15
        Me.btn_download.Text = "Download"
        Me.btn_download.UseVisualStyleBackColor = True
        '
        'Downloads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 215)
        Me.Controls.Add(Me.lblspd)
        Me.Controls.Add(Me.lblsize)
        Me.Controls.Add(Me.lblsloc)
        Me.Controls.Add(Me.lblpercent)
        Me.Controls.Add(Me.lblstat)
        Me.Controls.Add(Me.lbldownloading)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Save_Location_Text_Box)
        Me.Controls.Add(Me.Where_To_Save_Label)
        Me.Controls.Add(Me.Url_Text_Box)
        Me.Controls.Add(Me.Url_Label)
        Me.Controls.Add(Me.brws)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_download)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Downloads"
        Me.Text = "Downloads"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblspd As System.Windows.Forms.Label
    Friend WithEvents lblsize As System.Windows.Forms.Label
    Friend WithEvents lblsloc As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblpercent As System.Windows.Forms.Label
    Friend WithEvents lblstat As System.Windows.Forms.Label
    Friend WithEvents lbldownloading As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Save_Location_Text_Box As System.Windows.Forms.TextBox
    Friend WithEvents Where_To_Save_Label As System.Windows.Forms.Label
    Friend WithEvents Url_Text_Box As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Url_Label As System.Windows.Forms.Label
    Friend WithEvents brws As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_download As System.Windows.Forms.Button
End Class
