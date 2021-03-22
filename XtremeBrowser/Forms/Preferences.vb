Imports System.Runtime.InteropServices
Imports System.IO
Public Class Preferences
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
    End Structure
    <DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function
    Private Sub Preferences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Download_Path_Input_Field.Text = (Current_User_Downloads_Path)
        User_Input_Field.Text = (Current_User)
        Password_Input_Field.Text = (Current_User_Password)
        If XtremeBrowser.Filter_On_Startup = True Then
            Load_Filter_At_Startup_CheckBox.Checked = True
        End If
        If XtremeBrowser.Private_Browsing_On_Startup = True Then
            Load_Private_Browsing_At_Startup_CheckBox.Checked = True
        End If
        If XtremeBrowser.Clear_History_On_Shutdown = True Then
            Clear_Browsing_History_On_Shutdown_CheckBox.Checked = True
        End If
        If Current_User_Theme = ("Default") Then
            Me.BackColor = Color.Black
            Me.BackgroundImage = Nothing
            General_Tab_Page.BackgroundImage = Nothing
            Appearance_Tab_Page.BackgroundImage = Nothing
            Privacy_Tab_Page.BackgroundImage = Nothing
            Homepage_Group_Box.ForeColor = Color.Black
            Search_Engine_Group_Box.ForeColor = Color.Black
            Downloads_Group_Box.ForeColor = Color.Black
            General_Tab_Page.ForeColor = Color.Black
            Appearance_Tab_Page.ForeColor = Color.Black
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.Black
            Privacy_Group_Box.ForeColor = Color.Black
            User_Settigs_Group_Box.ForeColor = Color.Black
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
            Dim margins As MARGINS = New MARGINS
            margins.cxLeftWidth = 2
            margins.cxRightWidth = 2
            margins.cyTopHeight = 23
            margins.cyBottomHeight = 2
            Dim hwnd As IntPtr = Handle
            Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
        ElseIf Current_User_Theme = ("Dark Forest") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Dark_Forest
            General_Tab_Page.BackgroundImage = My.Resources.Dark_Forest
            Appearance_Tab_Page.BackgroundImage = My.Resources.Dark_Forest
            Privacy_Tab_Page.BackgroundImage = My.Resources.Dark_Forest
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Bones Leather") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Bones_Leather
            General_Tab_Page.BackgroundImage = My.Resources.Bones_Leather
            Appearance_Tab_Page.BackgroundImage = My.Resources.Bones_Leather
            Privacy_Tab_Page.BackgroundImage = My.Resources.Bones_Leather
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Trentacinque") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.trentacinque
            General_Tab_Page.BackgroundImage = My.Resources.trentacinque
            Appearance_Tab_Page.BackgroundImage = My.Resources.trentacinque
            Privacy_Tab_Page.BackgroundImage = My.Resources.trentacinque
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Luxury Lining") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Luxury_Lining
            General_Tab_Page.BackgroundImage = My.Resources.Luxury_Lining
            Appearance_Tab_Page.BackgroundImage = My.Resources.Luxury_Lining
            Privacy_Tab_Page.BackgroundImage = My.Resources.Luxury_Lining
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Pattern 42") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Pattern_42
            General_Tab_Page.BackgroundImage = My.Resources.Pattern_42
            Appearance_Tab_Page.BackgroundImage = My.Resources.Pattern_42
            Privacy_Tab_Page.BackgroundImage = My.Resources.Pattern_42
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Animus Mix") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Animus_Mix
            General_Tab_Page.BackgroundImage = My.Resources.Animus_Mix
            Appearance_Tab_Page.BackgroundImage = My.Resources.Animus_Mix
            Privacy_Tab_Page.BackgroundImage = My.Resources.Animus_Mix
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Pattern 156") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Pattern_156
            General_Tab_Page.BackgroundImage = My.Resources.Pattern_156
            Appearance_Tab_Page.BackgroundImage = My.Resources.Pattern_156
            Privacy_Tab_Page.BackgroundImage = My.Resources.Pattern_156
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Pattern 09") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Pattern_09
            General_Tab_Page.BackgroundImage = My.Resources.Pattern_09
            Appearance_Tab_Page.BackgroundImage = My.Resources.Pattern_09
            Privacy_Tab_Page.BackgroundImage = My.Resources.Pattern_09
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Pattern 52") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Pattern_52
            General_Tab_Page.BackgroundImage = My.Resources.Pattern_52
            Appearance_Tab_Page.BackgroundImage = My.Resources.Pattern_52
            Privacy_Tab_Page.BackgroundImage = My.Resources.Pattern_52
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Pattern 41") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Pattern_41
            General_Tab_Page.BackgroundImage = My.Resources.Pattern_41
            Appearance_Tab_Page.BackgroundImage = My.Resources.Pattern_41
            Privacy_Tab_Page.BackgroundImage = My.Resources.Pattern_41
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        ElseIf Current_User_Theme = ("Threaded Dark") Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Threaded_Dark_One
            General_Tab_Page.BackgroundImage = My.Resources.Threaded_Dark_One
            Appearance_Tab_Page.BackgroundImage = My.Resources.Threaded_Dark_One
            Privacy_Tab_Page.BackgroundImage = My.Resources.Threaded_Dark_One
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        Else
            XtremeBrowser.Recover()
        End If
        Home_Page_Input_Field.Text = Current_User_Homepage
        Me.Text = (Current_User + " Preferences")
    End Sub

#Region "Checked Themes"

    Private Sub Bones_Leather_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bones_Leather_Radio_Button.CheckedChanged
        If Bones_Leather_Radio_Button.Checked = True = True Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Bones_Leather
            General_Tab_Page.BackgroundImage = My.Resources.Bones_Leather
            Appearance_Tab_Page.BackgroundImage = My.Resources.Bones_Leather
            Privacy_Tab_Page.BackgroundImage = My.Resources.Bones_Leather
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Dark_Forest_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dark_Forest_Radio_Button.CheckedChanged
        If Dark_Forest_Radio_Button.Checked = True Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Dark_Forest
            General_Tab_Page.BackgroundImage = My.Resources.Dark_Forest
            Appearance_Tab_Page.BackgroundImage = My.Resources.Dark_Forest
            Privacy_Tab_Page.BackgroundImage = My.Resources.Dark_Forest
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Trentacinque_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Trentacinque_Radio_Button.CheckedChanged
        If Trentacinque_Radio_Button.Checked = True Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.trentacinque
            General_Tab_Page.BackgroundImage = My.Resources.trentacinque
            Appearance_Tab_Page.BackgroundImage = My.Resources.trentacinque
            Privacy_Tab_Page.BackgroundImage = My.Resources.trentacinque
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Luxury_Lining_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Luxury_Lining_Radio_Button.CheckedChanged
        If Luxury_Lining_Radio_Button.Checked = True Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Luxury_Lining
            General_Tab_Page.BackgroundImage = My.Resources.Luxury_Lining
            Appearance_Tab_Page.BackgroundImage = My.Resources.Luxury_Lining
            Privacy_Tab_Page.BackgroundImage = My.Resources.Luxury_Lining
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Pattern_42_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pattern_42_Radio_Button.CheckedChanged
        If Pattern_42_Radio_Button.Checked = True Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Pattern_42
            General_Tab_Page.BackgroundImage = My.Resources.Pattern_42
            Appearance_Tab_Page.BackgroundImage = My.Resources.Pattern_42
            Privacy_Tab_Page.BackgroundImage = My.Resources.Pattern_42
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            Downloads_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Animus_Mix_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Animus_Mix_Radio_Button.CheckedChanged
        If Animus_Mix_Radio_Button.Checked = True Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Animus_Mix
            General_Tab_Page.BackgroundImage = My.Resources.Animus_Mix
            Appearance_Tab_Page.BackgroundImage = My.Resources.Animus_Mix
            Privacy_Tab_Page.BackgroundImage = My.Resources.Animus_Mix
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Pattern_156_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pattern_156_Radio_Button.CheckedChanged
        If Pattern_156_Radio_Button.Checked = True Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Pattern_156
            General_Tab_Page.BackgroundImage = My.Resources.Pattern_156
            Appearance_Tab_Page.BackgroundImage = My.Resources.Pattern_156
            Privacy_Tab_Page.BackgroundImage = My.Resources.Pattern_156
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Pattern_52_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pattern_52_Radio_Button.CheckedChanged
        Me.BackColor = SystemColors.Control
        Me.BackgroundImage = My.Resources.Pattern_52
        General_Tab_Page.BackgroundImage = My.Resources.Pattern_52
        Appearance_Tab_Page.BackgroundImage = My.Resources.Pattern_52
        Privacy_Tab_Page.BackgroundImage = My.Resources.Pattern_52
        Homepage_Group_Box.ForeColor = Color.White
        Search_Engine_Group_Box.ForeColor = Color.White
        General_Tab_Page.ForeColor = Color.White
        Appearance_Tab_Page.ForeColor = Color.White
        Apply_Button.ForeColor = Color.Black
        Apply_Button2.ForeColor = Color.Black
        Apply_Button3.ForeColor = Color.Black
        Ok_Button.ForeColor = Color.Black
        Change_Theme_Button.ForeColor = Color.Black
        Restore_Default_Button.ForeColor = Color.Black
        Privacy_Tab_Page.ForeColor = Color.White
        Privacy_Group_Box.ForeColor = Color.White
        User_Settigs_Group_Box.ForeColor = Color.White
        Request_Changes_btn.ForeColor = Color.Black
        Apply_btn.ForeColor = Color.Black
    End Sub

    Private Sub Pattern_41_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pattern_41_Radio_Button.CheckedChanged
        If Pattern_41_Radio_Button.Checked = True Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Pattern_41
            General_Tab_Page.BackgroundImage = My.Resources.Pattern_41
            Appearance_Tab_Page.BackgroundImage = My.Resources.Pattern_41
            Privacy_Tab_Page.BackgroundImage = My.Resources.Pattern_41
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Threaded_Darkness_Radio_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Threaded_Dark_Radio_Button.CheckedChanged
        If Threaded_Dark_Radio_Button.Checked = True Then
            Me.BackColor = SystemColors.Control
            Me.BackgroundImage = My.Resources.Threaded_Dark_One
            General_Tab_Page.BackgroundImage = My.Resources.Threaded_Dark_One
            Appearance_Tab_Page.BackgroundImage = My.Resources.Threaded_Dark_One
            Privacy_Tab_Page.BackgroundImage = My.Resources.Threaded_Dark_One
            Homepage_Group_Box.ForeColor = Color.White
            Search_Engine_Group_Box.ForeColor = Color.White
            General_Tab_Page.ForeColor = Color.White
            Appearance_Tab_Page.ForeColor = Color.White
            Apply_Button.ForeColor = Color.Black
            Apply_Button2.ForeColor = Color.Black
            Apply_Button3.ForeColor = Color.Black
            Ok_Button.ForeColor = Color.Black
            Change_Theme_Button.ForeColor = Color.Black
            Restore_Default_Button.ForeColor = Color.Black
            Privacy_Tab_Page.ForeColor = Color.White
            Privacy_Group_Box.ForeColor = Color.White
            User_Settigs_Group_Box.ForeColor = Color.White
            Request_Changes_btn.ForeColor = Color.Black
            Apply_btn.ForeColor = Color.Black
        End If
    End Sub

#End Region

#Region "Restore Default"

    Private Sub Restore_Default_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restore_Default_Button.Click
        Me.BackColor = Color.Black
        Me.BackgroundImage = Nothing
        General_Tab_Page.BackgroundImage = Nothing
        Appearance_Tab_Page.BackgroundImage = Nothing
        Privacy_Tab_Page.BackgroundImage = Nothing
        Homepage_Group_Box.ForeColor = Color.Black
        Search_Engine_Group_Box.ForeColor = Color.Black
        Downloads_Group_Box.ForeColor = Color.Black
        General_Tab_Page.ForeColor = Color.Black
        Appearance_Tab_Page.ForeColor = Color.Black
        Apply_Button.ForeColor = Color.Black
        Apply_Button2.ForeColor = Color.Black
        Apply_Button3.ForeColor = Color.Black
        Ok_Button.ForeColor = Color.Black
        Change_Theme_Button.ForeColor = Color.Black
        Restore_Default_Button.ForeColor = Color.Black
        Privacy_Tab_Page.ForeColor = Color.Black
        Privacy_Group_Box.ForeColor = Color.Black
        User_Settigs_Group_Box.ForeColor = Color.Black
        Request_Changes_btn.ForeColor = Color.Black
        Apply_btn.ForeColor = Color.Black
        XtremeBrowser.BackgroundImage = Nothing
        TabControl1.SelectedTab.BackgroundImage = Nothing
        TabControl1.SelectedTab.BackColor = Color.Transparent
        TabControl1.SelectedTab.ForeColor = Color.Black
        XtremeBrowser.ToolStrip1.BackColor = Color.Transparent
        XtremeBrowser.ToolStrip2.BackColor = Color.Transparent
        XtremeBrowser.ToolStrip1.BackgroundImage = Nothing
        XtremeBrowser.ToolStrip2.BackgroundImage = Nothing
        XtremeBrowser.ToolStrip3.BackColor = Color.Transparent
        XtremeBrowser.ToolStrip3.BackgroundImage = Nothing
        XtremeBrowser.ToolStrip2.BackgroundImage = Nothing
        XtremeBrowser.File_Menu.ForeColor = Color.Black
        XtremeBrowser.Edit_Menu.ForeColor = Color.Black
        XtremeBrowser.Tools_Menu.ForeColor = Color.Black
        XtremeBrowser.View_Menu.ForeColor = Color.Black
        XtremeBrowser.History_Menu.ForeColor = Color.Black
        XtremeBrowser.Bookmarks_Menu.ForeColor = Color.Black
        XtremeBrowser.Help_Menu.ForeColor = Color.Black
        XtremeBrowser.ToolStrip3.ForeColor = Color.Black
        XtremeBrowser.ForeColor = Color.Black
        Dim margins As MARGINS = New MARGINS
        margins.cxLeftWidth = 2
        margins.cxRightWidth = 2
        margins.cyTopHeight = 23
        margins.cyBottomHeight = 2
        Dim hwnd As IntPtr = Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
        Try
            Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
            sw_Theme.WriteLine("Default")
            sw_Theme.Close()
            MsgBox("Default Theme Restored.")
            Current_User_Theme = "Default"
        Catch ex As Exception
            MsgBox("An error occured.")
        End Try
    End Sub

#End Region

#Region "Change Theme"

    Private Sub Change_Theme_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Change_Theme_Button.Click
        If Dark_Forest_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Dark Forest")
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.Dark_Forest
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.Dark_Forest
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.Dark_Forest
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.Help_Menu.ForeColor = Color.White
                XtremeBrowser.ToolStrip3.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.White
                XtremeBrowser.BackgroundImage = My.Resources.Dark_Forest
                sw_Theme.Close()
                MsgBox("Theme Changed.")
                Current_User_Theme = ("Dark Forest")
            Catch ex As Exception
                MsgBox("An error occured.")
            End Try

        ElseIf Bones_Leather_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Bones Leather")
                XtremeBrowser.BackgroundImage = My.Resources.Bones_Leather
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.Bones_Leather
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.Bones_Leather
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.Bones_Leather
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.White
                XtremeBrowser.Help_Menu.ForeColor = Color.White
                XtremeBrowser.ToolStrip3.ForeColor = Color.White
                sw_Theme.Close()
                MsgBox("Theme Changed.")
                Current_User_Theme = ("Bones Leather")
            Catch ex As Exception
                MsgBox("An error occured.")
            End Try
        ElseIf Trentacinque_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Trentacinque")
                XtremeBrowser.BackgroundImage = My.Resources.trentacinque
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.trentacinque
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.trentacinque
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.trentacinque
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.Black
                XtremeBrowser.Help_Menu.ForeColor = Color.White
                XtremeBrowser.ToolStrip3.ForeColor = Color.White
                sw_Theme.Close()
                MsgBox("Theme Changed.")
                Current_User_Theme = ("Trentacinque")
            Catch ex As Exception
                MsgBox("An error occured")
            End Try
        ElseIf Luxury_Lining_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Luxury Lining")
                XtremeBrowser.BackgroundImage = My.Resources.Luxury_Lining
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.Luxury_Lining
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.Luxury_Lining
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.Luxury_Lining
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.White
                XtremeBrowser.Help_Menu.ForeColor = Color.White
                XtremeBrowser.ToolStrip3.ForeColor = Color.White
                sw_Theme.Close()
                MsgBox("Theme Changed")
                Current_User_Theme = ("Luxury Lining")
            Catch ex As Exception
                MsgBox("An error occured")
            End Try
        ElseIf Pattern_42_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Pattern 42")
                XtremeBrowser.BackgroundImage = My.Resources.Pattern_42
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.Pattern_42
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.Pattern_42
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.Pattern_42
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.White
                XtremeBrowser.Help_Menu.ForeColor = Color.White
                XtremeBrowser.ToolStrip3.ForeColor = Color.White
                sw_Theme.Close()
                MsgBox("Theme Changed")
                Current_User_Theme = ("Pattern 42")
            Catch ex As Exception
                MsgBox("An error occured.")
            End Try
        ElseIf Animus_Mix_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Animus Mix")
                XtremeBrowser.BackgroundImage = My.Resources.Animus_Mix
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.Animus_Mix
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.Animus_Mix
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.Animus_Mix
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.White
                XtremeBrowser.Help_Menu.ForeColor = Color.White
                XtremeBrowser.ToolStrip3.ForeColor = Color.White
                sw_Theme.Close()
                MsgBox("Theme Changed")
                Current_User_Theme = ("Animus Mix")
            Catch ex As Exception
                MsgBox("An error occured.")
            End Try
        ElseIf Pattern_156_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Pattern 156")
                XtremeBrowser.BackgroundImage = My.Resources.Pattern_156
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.Pattern_156
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.Pattern_156
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.Pattern_156
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.White
                XtremeBrowser.Help_Menu.ForeColor = Color.White
                XtremeBrowser.ToolStrip3.ForeColor = Color.White
                sw_Theme.Close()
                MsgBox("Theme Changed.")
                Current_User_Theme = ("Pattern 156")
            Catch ex As Exception
                MsgBox("An error occured.")
            End Try
        ElseIf Pattern_52_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Pattern 52")
                XtremeBrowser.BackgroundImage = My.Resources.Pattern_52
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.Pattern_52
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.Pattern_52
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.Pattern_52
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.White
                XtremeBrowser.Help_Menu.ForeColor = Color.White
                XtremeBrowser.ToolStrip3.ForeColor = Color.White
                sw_Theme.Close()
                MsgBox("Theme Changed")
                Current_User_Theme = ("Pattern 52")
            Catch ex As Exception
                MsgBox("An error occured.")
            End Try
        ElseIf Pattern_41_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Pattern 41")
                XtremeBrowser.BackgroundImage = My.Resources.Pattern_41
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.Pattern_41
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.Pattern_41
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.Pattern_41
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.White
                sw_Theme.Close()
                MsgBox("Theme Changed")
                Current_User_Theme = ("Pattern 42")
            Catch ex As Exception
                MsgBox("An error occured.")
            End Try
        ElseIf Threaded_Dark_Radio_Button.Checked = True Then
            Try
                Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Theme" + ".txt")
                sw_Theme.WriteLine("Threaded Dark")
                XtremeBrowser.BackgroundImage = My.Resources.Threaded_Dark_One
                XtremeBrowser.ToolStrip1.BackgroundImage = My.Resources.Threaded_Dark_One
                XtremeBrowser.ToolStrip2.BackgroundImage = My.Resources.Threaded_Dark_One
                XtremeBrowser.ToolStrip3.BackgroundImage = My.Resources.Threaded_Dark_One
                XtremeBrowser.File_Menu.ForeColor = Color.White
                XtremeBrowser.Edit_Menu.ForeColor = Color.White
                XtremeBrowser.Tools_Menu.ForeColor = Color.White
                XtremeBrowser.View_Menu.ForeColor = Color.White
                XtremeBrowser.Bookmarks_Menu.ForeColor = Color.White
                XtremeBrowser.History_Menu.ForeColor = Color.White
                XtremeBrowser.ForeColor = Color.White
                XtremeBrowser.Help_Menu.ForeColor = Color.White
                XtremeBrowser.ToolStrip3.ForeColor = Color.White
                sw_Theme.Close()
                MsgBox("Theme Changed.")
                Current_User_Theme = ("Threaded Dark")
            Catch ex As Exception
                MsgBox("An error occured.")
            End Try
        Else
            MsgBox("No Theme is selected.")
        End If
    End Sub

    Private Sub Dark_Forest_Picture_Box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dark_Forest_Picture_Box.Click

    End Sub

    Private Sub Appearance_Tab_Page_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Appearance_Tab_Page.Click

    End Sub

    Private Sub Apply_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apply_Button.Click
        Dim Homepage As String = Home_Page_Input_Field.Text
        If Homepage = ("") Then
            MsgBox("No Homepage was entered!")
        ElseIf Homepage <> ("") And Homepage.Contains("http://") Or Homepage.Contains("www.") Then
            Try
                Dim sw_Homepage As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Homepage" + ".txt")
                sw_Homepage.WriteLine(Homepage)
                Current_User_Homepage = Homepage
                sw_Homepage.Flush()
                sw_Homepage.Close()
                MsgBox("Homepage changed to " + Current_User_Homepage)
            Catch ex As Exception
                MsgBox("Homepage configuration file could not be accessed at this point, perhaps another process is using it")
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Invalid homepage format, Must contain www. or http://")
        End If

    End Sub

#End Region

#Region "Change Search Engine"

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apply_Button2.Click
        If Search_Engine_List_Box.SelectedItem = ("Google") Then
            Try
                If Current_User_Search_Engine = ("Google") Then
                    MsgBox("Your search engine is already selected as Google")
                Else
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
                    sw_Search_Engine.WriteLine("Google")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Current_User_Search_Engine = ("Google")
                    MsgBox("Search Engine changed to Google.")
                End If
            Catch ex As Exception
                MsgBox("Search Engine configuration file could not be accessed at this point, perhaps another process is using it")
            End Try
        ElseIf Search_Engine_List_Box.SelectedItem = ("Bing") Then
            Try
                If Current_User_Search_Engine = ("Bing") Then
                    MsgBox("Your search engine is already selected as Bing")
                Else
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
                    sw_Search_Engine.WriteLine("Bing")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Current_User_Search_Engine = ("Bing")
                    MsgBox("Search Engine changed to Bing.")
                End If
            Catch ex As Exception
                MsgBox("Search Engine configuration file could not be accessed at this point, perhaps another process is using it")
            End Try
        ElseIf Search_Engine_List_Box.SelectedItem = ("Yahoo") Then
            Try
                If Current_User_Search_Engine = ("Yahoo") Then
                    MsgBox("Your search engine is already selected as Yahoo.")
                Else
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
                    sw_Search_Engine.WriteLine("Yahoo")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Current_User_Search_Engine = ("Yahoo")
                    MsgBox("Search Engine changed to Yahoo.")
                End If
            Catch ex As Exception
                MsgBox("Search Engine configuration file could not be accessed at this point, perhaps another process is using it")
            End Try
        ElseIf Search_Engine_List_Box.SelectedItem = ("AOL") Then
            Try
                If Current_User_Search_Engine = ("AOL") Then
                    MsgBox("Your search engine is already selected as AOL.")
                Else
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
                    sw_Search_Engine.WriteLine("AOL")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Current_User_Search_Engine = ("AOL")
                    MsgBox("Search Engine changed to AOL.")
                End If
            Catch ex As Exception
                MsgBox("Search Engine configuration file could not be accessed at this point, perhaps another process is using it")
            End Try
        ElseIf Search_Engine_List_Box.SelectedItem = ("Wikipedia") Then
            Try
                If Current_User_Search_Engine = ("Wikipedia") Then
                    MsgBox("Your search engine is already selected as Wikipedia.")
                Else
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
                    sw_Search_Engine.WriteLine("Wikipedia")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Current_User_Search_Engine = ("Wikipedia")
                    MsgBox("Search Engine changed to Wikipedia.")
                End If
            Catch ex As Exception
                MsgBox("Search Engine configuration file could not be accessed at this point, perhaps another process is using it")
            End Try
        ElseIf Search_Engine_List_Box.SelectedItem = ("Ebay") Then
            Try
                If Current_User_Search_Engine.Contains("Ebay") Then
                    MsgBox("Your search engine is already selected as Ebay.")
                Else
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
                    sw_Search_Engine.WriteLine("Ebay")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Current_User_Search_Engine = ("Ebay")
                    MsgBox("Search Engine changed to Ebay.")
                End If
            Catch ex As Exception
                MsgBox("Search Engine configuration file could not be accessed at this point, perhaps another process is using it")
            End Try
        ElseIf Search_Engine_List_Box.SelectedItem = ("Ask") Then
            Try
                If Current_User_Search_Engine = ("Ask") Then
                    MsgBox("Your search engine is already selected as Ask.")
                Else
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
                    sw_Search_Engine.WriteLine("Ask")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Current_User_Search_Engine = ("Ask")
                    MsgBox("Search Engine changed to Ask.")
                End If
            Catch ex As Exception
                MsgBox("Search Engine configuration file could not be accessed at this point, perhaps another process is using it")
            End Try
        ElseIf Search_Engine_List_Box.SelectedItem = ("Youtube") Then
            Try
                If Current_User_Search_Engine = ("Youtube") Then
                    MsgBox("Your search engine is already selected as Youtube.")
                Else
                    Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
                    sw_Search_Engine.WriteLine("Youtube")
                    sw_Search_Engine.Flush()
                    sw_Search_Engine.Close()
                    Current_User_Search_Engine = ("Youtube")
                    MsgBox("Search Engine changed to Youtube.")
                End If
            Catch ex As Exception
                MsgBox("Search Engine configuration file could not be accessed at this point, perhaps another process is using it")
            End Try
        ElseIf Search_Engine_List_Box.SelectedItem = ("") Then
            MsgBox("No search engine was selected")
        End If

    End Sub
#End Region

    Private Sub Ok_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_Button.Click
        Me.Close()
    End Sub

    Private Sub Home_Page_Input_Field_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Home_Page_Input_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Apply_Button.PerformClick()
        End If
    End Sub

    Private Sub Search_Engine_List_Box_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Search_Engine_List_Box.KeyDown
        If e.KeyCode = Keys.Enter Then
            Apply_Button2.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apply_Button3.Click
        Dim Download_Path As String = Download_Path_Input_Field.Text
        If Download_Path = ("") Then
            MsgBox("No Download path was entered.")
        ElseIf My.Computer.FileSystem.DirectoryExists(Download_Path) = True Then
            Download_Path_Input_Field.Text = ("")
            Dim sw_Downloads_Path As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Downloads.txt")
            sw_Downloads_Path.Write(Download_Path)
            sw_Downloads_Path.Flush()
            sw_Downloads_Path.Close()
            Current_User_Downloads_Path = (Download_Path_Input_Field.Text)
        Else
            MsgBox("Invalid file path entered.")
        End If
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Request_Changes_btn.Click
        Dim user As String = User_Input_Field.Text
        Dim pass As String = Password_Input_Field.Text
        If User_Input_Field.Text = ("") Then
            MsgBox("No username is entered.", MsgBoxStyle.Critical)
        ElseIf Password_Input_Field.Text = ("") Then
            MsgBox("No password is entered.", MsgBoxStyle.Critical)
        ElseIf My.Settings.User_Name.Contains(user) Then
            User_Input_Field.Text = ("")
            Password_Input_Field.Text = ("")
            MsgBox("Username " + User_Input_Field.Text + " already exists.", MsgBoxStyle.Critical)
        Else
            My.Settings.User_Name.Remove(Current_User)
            My.Settings.Password.Remove(Current_User_Password)
            FileIO.FileSystem.RenameDirectory(Application.StartupPath.ToString + "/Users/" + Current_User, user)
            My.Settings.User_Name.Add(user)
            My.Settings.Password.Add(pass)
            My.Settings.Save()
            Current_User = (user)
            Current_User_Password = (pass)
            MsgBox("User credentials changed successfully.")
        End If
    End Sub

    Private Sub User_Input_Field_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles User_Input_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Request_Changes_btn.PerformClick()
        End If
    End Sub

    Private Sub Password_Input_Field_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Password_Input_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Request_Changes_btn.PerformClick()
        End If
    End Sub

    Private Sub Apply_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apply_btn.Click
        If Load_Filter_At_Startup_CheckBox.Checked = True Then
            If XtremeBrowser.Filter_On_Startup = False Then
                Dim sw_Filter As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Filter.txt")
                sw_Filter.WriteLine("True")
                sw_Filter.Flush()
                sw_Filter.Close()
                XtremeBrowser.Filter_On_Startup = True
                MsgBox("Browsing Filter will now start each time the browser is loaded.")
                XtremeBrowser.Browsing_Filter = True
                XtremeBrowser.Initiate_Browsing_Filter_Menu_Item.Text = ("Deinitialize Browsing Filter")
            End If
        Else
            If XtremeBrowser.Filter_On_Startup = True Then
                Dim sw_Filter As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Filter.txt")
                sw_Filter.WriteLine("False")
                sw_Filter.Flush()
                sw_Filter.Close()
                XtremeBrowser.Filter_On_Startup = False
                XtremeBrowser.Browsing_Filter = False
                XtremeBrowser.Initiate_Browsing_Filter_Menu_Item.Text = ("Initiate Browsing Filter")
                MsgBox("Browsing Filter will no longer start when the browser is loaded.")
            End If
        End If
        If Load_Private_Browsing_At_Startup_CheckBox.Checked = True Then
            If XtremeBrowser.Private_Browsing_On_Startup = False Then
                Dim sw_Private_Browsing As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Private Browsing.txt")
                sw_Private_Browsing.WriteLine("True")
                sw_Private_Browsing.Flush()
                sw_Private_Browsing.Close()
                XtremeBrowser.Private_Browsing = True
                MsgBox("Private browsing will now start each time the browser starts.")
            End If
        Else
            If XtremeBrowser.Private_Browsing_On_Startup = True Then
                Dim sw_Private_Browsing As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Private Browsing.txt")
                sw_Private_Browsing.WriteLine("False")
                sw_Private_Browsing.Flush()
                sw_Private_Browsing.Close()
                XtremeBrowser.Private_Browsing = False
                MsgBox("Private browsing will no longer start when the browser is loaded.")

            End If
        End If
        If Clear_Browsing_History_On_Shutdown_CheckBox.Checked = True Then
            If XtremeBrowser.Clear_History_On_Shutdown = False Then
                Dim sw_Clear_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Clear History.txt")
                sw_Clear_History.WriteLine("True")
                sw_Clear_History.Flush()
                sw_Clear_History.Close()
                XtremeBrowser.Clear_History_On_Shutdown = True
                MsgBox("History will now be cleared each time the user logs out or the browser shutsdown.")
            End If
        Else
            If XtremeBrowser.Clear_History_On_Shutdown = True Then
                Dim sw_Clear_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Clear History.txt")
                sw_Clear_History.WriteLine("False")
                sw_Clear_History.Flush()
                sw_Clear_History.Close()
                XtremeBrowser.Clear_History_On_Shutdown = False
                MsgBox("History will no longer be cleared each time the user logs out or the browser shutsdown.")
            End If
        End If
    End Sub
End Class