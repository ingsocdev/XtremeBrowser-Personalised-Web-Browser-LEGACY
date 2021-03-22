Public Class Timed_Shutdown

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_btn.Click
        Dim Seconds As Integer = Time_Input_Field.Text
        Try
            If Seconds.ToString = ("") Then
                MsgBox("No shutdown time was entered. Please enter the shutdown time in minutes.")
            Else
                Seconds = Seconds * 60000
                XtremeBrowser.Shutdown_Timer.Interval = Seconds
                XtremeBrowser.Shutdown_Timer.Start()
                XtremeBrowser.Timed_Shutdown_Menu_Item.Text = ("Cancel Shutdown")
                XtremeBrowser.Timed_Shutdown_Menu_Item.Image = My.Resources.Shutdown_Timer_Cancel_btn
                Seconds = Seconds / 60000
                MsgBox("Computer will shutdown in " + Seconds.ToString + " minutes.")
                XtremeBrowser.Shutdown_Toggle = True
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Invalid input, the number you entered was either too high or a string. Please enter the shutdown time in minutes." + ex.ToString)
        End Try
    End Sub

    Private Sub Timed_Shutdown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Time_Input_Field_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Time_Input_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ok_btn.PerformClick()
        End If
    End Sub
End Class