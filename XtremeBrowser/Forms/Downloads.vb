Imports System.Net
Public Class Downloads
    Dim whereToSave As String
    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)

    Public Sub DownloadComplete(ByVal cancelled As Boolean)
        Me.Url_Text_Box.Enabled = True
        Me.btn_download.Enabled = True

        If cancelled Then
            Me.btn_cancel.Enabled = False
            Me.lblstat.Text = "Status : " & "Cancelled"
            MessageBox.Show("Download Cancelled !", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.btn_cancel.Enabled = False
            Me.lblstat.Text = "Status : " & "Successfully downloaded"
            MessageBox.Show("Download Succeded !", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.ProgressBar1.Value = 0
    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)

        Me.lblsize.Text = "Size : " & Math.Round((length / 1024), 2) & " KB"
        Me.lbldownloading.Text = "Downloading : " & Me.Url_Text_Box.Text
        Me.lblstat.Text = "Status : " & Math.Round((position / 1024), 2) & " KB of " & Math.Round((length / 1024), 2) & "KB (" & Me.ProgressBar1.Value & "%)"
        Me.lblpercent.Text = Me.ProgressBar1.Value & "%"
        If speed = -1 Then
            Me.lblspd.Text = "Speed : " & "calculating..."
        Else
            Me.lblspd.Text = "Speed : " & Math.Round((speed / 1024), 2) & " KB/s"
        End If

        Me.ProgressBar1.Value = percent
    End Sub

    Private Sub btn_download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_download.Click
        If Me.Url_Text_Box.Text <> "" AndAlso Me.Url_Text_Box.Text.StartsWith("http://") Then
            Me.whereToSave = Me.Save_Location_Text_Box.Text
            Me.SaveFileDialog1.FileName = ""
            Me.lblsloc.Text = "Save to : " & whereToSave
            Me.Url_Text_Box.Enabled = False
            Me.btn_download.Enabled = False
            Me.btn_cancel.Enabled = True
            Me.Save_Location_Text_Box.Enabled = False
            Me.brws.Enabled = False
            Me.BackgroundWorker1.RunWorkerAsync()
        Else
            MessageBox.Show("This url is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub brws_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brws.Click
        Me.SaveFileDialog1.FileName = Me.Url_Text_Box.Text.Split("/"c)(Me.Url_Text_Box.Text.Split("/"c).Length - 1)
        Me.lblname.Text = "Name : " & Me.Url_Text_Box.Text.Split("/"c)(Me.Url_Text_Box.Text.Split("/"c).Length - 1)
        Me.SaveFileDialog1.ShowDialog()
        Me.Save_Location_Text_Box.Text = Me.SaveFileDialog1.FileName
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.btn_download.Enabled = False
        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try
            theRequest = WebRequest.Create(Me.Url_Text_Box.Text)
            theResponse = theRequest.GetResponse
        Catch ex As Exception
            MessageBox.Show("An error occurred while downloading file. Possibe causes:" & ControlChars.CrLf & _
                            "1) File doesn't exist" & ControlChars.CrLf & _
                            "2) Remote server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
            Me.Invoke(cancelDelegate, True)
            Exit Sub
        End Try
        Dim length As Long = theResponse.ContentLength
        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, 0)
        Dim writeStream As New IO.FileStream(Me.whereToSave, IO.FileMode.Create)
        Dim nRead As Integer
        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Integer = 0

        Do
            If BackgroundWorker1.CancellationPending Then
                Exit Do
            End If
            speedtimer.Start()
            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)
            nRead += bytesread
            Dim percent As Short = (nRead / length) * 100
            Me.Invoke(safedelegate, length, nRead, percent, currentspeed)

            If bytesread = 0 Then Exit Do
            writeStream.Write(readBytes, 0, bytesread)
            speedtimer.Stop()
            readings += 1

            If readings >= 5 Then
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop

        theResponse.GetResponseStream.Close()
        writeStream.Close()

        If Me.BackgroundWorker1.CancellationPending Then
            IO.File.Delete(Me.whereToSave)
            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
            Me.Invoke(cancelDelegate, True)
            Exit Sub
        End If

        Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
        Me.Invoke(completeDelegate, False)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btn_cancel.Enabled = False
        Save_Location_Text_Box.Text = (Current_User_Downloads_Path)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class
