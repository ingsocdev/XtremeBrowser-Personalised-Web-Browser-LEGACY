Imports System.IO

Public Class XtremeBrowser

#Region "Public Declarations"
    Public Private_Browsing As Boolean
    Public Private_Browsing_Toggle As Boolean = True
    Public Browsing_Filter_Toggle As Boolean = True
    Public Shutdown_Toggle As Boolean
    Public Browsing_Filter As Boolean
    Public App_Instance As String = 0
    Public User As String
    Public Pass As String
    Public Msg As String
    Public Msg_User As String
    Public Cut As Boolean
    Public Filter_On_Startup As Boolean
    Public Private_Browsing_On_Startup As Boolean
    Public Clear_History_On_Shutdown As Boolean
    Public File_Open As Boolean
    Public Load_Failed As Boolean
#End Region

#Region "Tabs"

    Public Sub AddTab(ByRef URL As String, ByRef TabControl As TabControl)
        Dim NewTab As New TabPage
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser.Tag = NewTab
        NewTab.Tag = Xtreme_Browser
        TabControl.TabPages.Add(NewTab)
        NewTab.Controls.Add(Xtreme_Browser)
        TabControl1.SelectTab(NewTab)
        Xtreme_Browser.Dock = DockStyle.Fill
        Xtreme_Browser.Navigate(URL)

    End Sub


    Private Sub Remove_Tab_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TabControl1.TabCount <= 1 Then
            MsgBox("Cannot close last tab.", MsgBoxStyle.Critical)
        Else
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
            Dim Xtreme_Browser As New Xtreme_Browser
            Xtreme_Browser = TabControl1.SelectedTab.Tag
            Me.Text = ("Xtreme Browser User: " & Current_User & ", " & Xtreme_Browser.DocumentTitle)
        End If
    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = TabControl1.SelectedTab.Tag
        Me.Text = ("Xtreme Browser User: " & Current_User & ", " & Xtreme_Browser.DocumentTitle)
        Current_Url = Xtreme_Browser.Url.ToString
        Navigation_box.Text = (Current_Url.ToString)
            Dim Url As Uri = New Uri(Navigation_box.Text)
            If Url.HostNameType = UriHostNameType.Dns Then
                Dim Icon_Url As String
            Try
                Icon_Url = "http://" + Url.Host + "/favicon.ico"
                Dim Request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(Icon_Url)
                Dim Response As System.Net.HttpWebResponse = Request.GetResponse
                Dim Stream As System.IO.Stream = Response.GetResponseStream
                Dim favicon = Image.FromStream(Stream)
                Me.Favicon.Image = (favicon)
                Me.Favicon.ToolTipText = (Xtreme_Browser.DocumentTitle)
                Me.Favicon.Visible = True
            Catch
                Try
                    Icon_Url = "http://" + Url.Host + "/Images/favicon.ico"
                    Dim Request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(Icon_Url)
                    Dim Response As System.Net.HttpWebResponse = Request.GetResponse
                    Dim Stream As System.IO.Stream = Response.GetResponseStream
                    Dim favicon = Image.FromStream(Stream)
                    Me.Favicon.Image = (favicon)
                    Me.Favicon.ToolTipText = (Xtreme_Browser.DocumentTitle)
                    Me.Favicon.Visible = True
                Catch
                    Me.Favicon.Visible = False
                End Try
            End Try
            End If
    End Sub

#End Region

#Region "Recover"

    Function Recover()
        MsgBox("User Files Corrupted! Attempting recovery", MsgBoxStyle.Critical)
        If IO.Directory.Exists("/Users/" + Current_User) Then
            Application.StartupPath.Remove("/Users/" + Current_User)
            Dim sw_Bookmarks As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Bookmarks" + ".txt")
            sw_Bookmarks.Flush()
            sw_Bookmarks.Close()
            Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\History" + ".txt")
            sw_History.Flush()
            sw_History.Close()
            Dim sw_Homepage As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Homepage" + ".txt")
            sw_Homepage.Write("http://www.xtremetech.co.cc")
            sw_Homepage.Flush()
            sw_Homepage.Close()
            Current_User_Homepage = "http://www.xtremetech.co.cc"
            Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Theme" + ".txt")
            sw_Theme.Write("Default")
            sw_Theme.Flush()
            sw_Theme.Close()
            Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
            sw_Search_Engine.WriteLine("Google")
            sw_Search_Engine.Flush()
            sw_Search_Engine.Close()
            Dim sw_Filter As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Filter" + ".txt")
            sw_Filter.WriteLine("False")
            sw_Filter.Flush()
            sw_Filter.Close()
            Dim sw_Private_Browsing As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Private Browsing" + ".txt")
            sw_Private_Browsing.WriteLine("False")
            sw_Private_Browsing.Flush()
            sw_Private_Browsing.Close()
            Dim sw_Clear_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Clear History" + ".txt")
            sw_Clear_History.WriteLine("False")
            sw_Clear_History.Flush()
            sw_Clear_History.Close()

        Else
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/Users/" + Current_User)
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/Users/" + Current_User + "/Downloads")
            Dim sw_Bookmarks As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Bookmarks" + ".txt")
            sw_Bookmarks.Flush()
            sw_Bookmarks.Close()
            Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\History" + ".txt")
            sw_History.Flush()
            sw_History.Close()
            Dim sw_Homepage As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Homepage" + ".txt")
            sw_Homepage.Write("http://www.xtremetech.co.cc")
            Current_User_Homepage = "http://www.xtremetech.co.cc"
            sw_Homepage.Flush()
            sw_Homepage.Close()
            Dim sw_Theme As New StreamWriter(Application.StartupPath.ToString + "/Users/" + User + "\Theme" + ".txt")
            sw_Theme.Write("Default")
            sw_Theme.Flush()
            sw_Theme.Close()
            Dim sw_Search_Engine As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Search Engine" + ".txt")
            sw_Search_Engine.WriteLine("Google")
            sw_Search_Engine.Flush()
            sw_Search_Engine.Close()
            Dim sw_Filter As New StreamWriter(Application.StartupPath.ToString + "/Users/" + User + "\Filter" + ".txt")
            sw_Filter.WriteLine("False")
            sw_Filter.Flush()
            sw_Filter.Close()
            Dim sw_Private_Browsing As New StreamWriter(Application.StartupPath.ToString + "/Users/" + User + "\Private Browsing" + ".txt")
            sw_Private_Browsing.WriteLine("False")
            sw_Private_Browsing.Flush()
            sw_Private_Browsing.Close()
            Dim sw_Clear_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + User + "\Clear History" + ".txt")
            sw_Clear_History.WriteLine("False")
            sw_Clear_History.Flush()
            sw_Clear_History.Close()
            MsgBox("New User profile created for user " + Current_User, MsgBoxStyle.OkOnly)
        End If
        Return 0
    End Function

#End Region

#Region "Load Theme"

    Function loadTheme()
        If My.Computer.FileSystem.FileExists(Application.StartupPath.ToString + "/Users/" + Current_User + "\Theme" + ".txt") Then
            Dim sr_Theme As New StreamReader(Application.StartupPath.ToString + "/Users/" + Current_User + "\Theme" + ".txt")
            Dim themeContents As String = sr_Theme.ReadLine
            If themeContents.Contains("Dark Forest") Then
                Me.BackgroundImage = My.Resources.Dark_Forest
                ToolStrip1.BackgroundImage = My.Resources.Dark_Forest
                ToolStrip2.BackgroundImage = My.Resources.Dark_Forest
                ToolStrip3.BackgroundImage = My.Resources.Dark_Forest
                ForeColor = Color.White
                Current_User_Theme = ("Dark Forest")
            ElseIf themeContents.Contains("Bones Leather") Then
                Me.BackgroundImage = My.Resources.Bones_Leather
                ToolStrip1.BackgroundImage = My.Resources.Bones_Leather
                ToolStrip2.BackgroundImage = My.Resources.Bones_Leather
                ToolStrip3.BackgroundImage = My.Resources.Bones_Leather
                ForeColor = Color.White
                Current_User_Theme = ("Bones Leather")
            ElseIf themeContents.Contains("Trentacinque") Then
                Me.BackgroundImage = My.Resources.trentacinque
                ToolStrip1.BackgroundImage = My.Resources.trentacinque
                ToolStrip2.BackgroundImage = My.Resources.trentacinque
                ToolStrip3.BackgroundImage = My.Resources.trentacinque
                ForeColor = Color.White
                Current_User_Theme = ("Trentacinque")
            ElseIf themeContents.Contains("Luxury Lining") Then
                Me.BackgroundImage = My.Resources.Luxury_Lining
                ToolStrip1.BackgroundImage = My.Resources.Luxury_Lining
                ToolStrip2.BackgroundImage = My.Resources.Luxury_Lining
                ToolStrip3.BackgroundImage = My.Resources.Luxury_Lining
                Me.ForeColor = Color.White
                Current_User_Theme = ("Luxury Lining")
            ElseIf themeContents.Contains("Pattern 42") Then
                Me.BackgroundImage = My.Resources.Pattern_42
                ToolStrip1.BackgroundImage = My.Resources.Pattern_42
                ToolStrip2.BackgroundImage = My.Resources.Pattern_42
                ToolStrip3.BackgroundImage = My.Resources.Pattern_42
                Me.ForeColor = Color.White
                Current_User_Theme = ("Pattern 42")
            ElseIf themeContents.Contains("Animus Mix") Then
                Me.BackgroundImage = My.Resources.Animus_Mix
                ToolStrip1.BackgroundImage = My.Resources.Animus_Mix
                ToolStrip2.BackgroundImage = My.Resources.Animus_Mix
                ToolStrip3.BackgroundImage = My.Resources.Animus_Mix
                Me.ForeColor = Color.White
                Current_User_Theme = ("Animus Mix")
            ElseIf themeContents.Contains("Pattern 156") Then
                Me.BackgroundImage = My.Resources.Pattern_156
                ToolStrip1.BackgroundImage = My.Resources.Pattern_156
                ToolStrip2.BackgroundImage = My.Resources.Pattern_156
                ToolStrip3.BackgroundImage = My.Resources.Pattern_156
                Me.ForeColor = Color.White
                Current_User_Theme = ("Pattern 156")
            ElseIf themeContents.Contains("Pattern 52") Then
                Me.BackgroundImage = My.Resources.Pattern_52
                ToolStrip1.BackgroundImage = My.Resources.Pattern_52
                ToolStrip2.BackgroundImage = My.Resources.Pattern_52
                ToolStrip3.BackgroundImage = My.Resources.Pattern_52
                Me.ForeColor = Color.White
                Current_User_Theme = ("Pattern 52")
            ElseIf themeContents.Contains("Pattern 41") Then
                Me.BackgroundImage = My.Resources.Pattern_41
                ToolStrip1.BackgroundImage = My.Resources.Pattern_41
                ToolStrip2.BackgroundImage = My.Resources.Pattern_41
                ToolStrip3.BackgroundImage = My.Resources.Pattern_41
                Me.ForeColor = Color.White
                Current_User_Theme = ("Pattern 41")
            ElseIf themeContents.Contains("Threaded Dark") Then
                Me.BackgroundImage = My.Resources.Threaded_Dark_One
                ToolStrip1.BackgroundImage = My.Resources.Threaded_Dark_One
                ToolStrip2.BackgroundImage = My.Resources.Threaded_Dark_One
                ToolStrip3.BackgroundImage = My.Resources.Threaded_Dark_One
                Me.ForeColor = Color.White
                Current_User_Theme = ("Threaded Dark")
            ElseIf themeContents.Contains("Default") Then
                Me.BackgroundImage = Nothing
                ToolStrip1.BackgroundImage = Nothing
                ToolStrip2.BackgroundImage = Nothing
                ToolStrip3.BackgroundImage = Nothing
                ToolStrip1.BackColor = Color.Transparent
                ToolStrip2.BackColor = Color.Transparent
                ToolStrip3.BackColor = Color.Transparent
                Current_User_Theme = ("Default")
            Else
                MsgBox("Invalid Theme!")

            End If
            sr_Theme.Close()

        Else
            Recover()
        End If
        Return Nothing
    End Function

#End Region

#Region "Load Settings"

    Private Sub Tom_Browser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStrip1.Renderer = New CustomRenderer
        ToolStrip2.Renderer = New CustomRenderer
        ToolStrip3.Renderer = New CustomRenderer
        ToolStrip1.Enabled = False
        ToolStrip2.Enabled = False
        ToolStrip3.Enabled = False
        loadTheme()
        loadSettings()
        AddTab(Current_User_Homepage, TabControl1)
    End Sub

    Function loadSettings()
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Homepage.txt") Then
            Try
                Dim sr_Homepage As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "\Homepage" + ".txt")
                Current_User_Homepage = sr_Homepage.ReadLine
                sr_Homepage.Close()
            Catch ex As Exception
                MsgBox("There was an error reading the homepage configuration file")
            End Try
        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/History.txt") Then

        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Bookmarks.txt") Then

        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Search Engine.txt") Then
            Try
                Dim sr_Search_Engine As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "\Search Engine" + ".txt")
                Current_User_Search_Engine = sr_Search_Engine.ReadLine
                sr_Search_Engine.Close()
            Catch ex As Exception
                MsgBox("There was an error reading the search engine configuration file")
            End Try
        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Filter.txt") Then
            Try
                Dim sr_Filter As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "/Filter" + ".txt")
                If sr_Filter.ReadLine = ("True") Then
                    sr_Filter.Close()
                    Filter_On_Startup = True
                    Me.Initiate_Browsing_Filter_Menu_Item.Text = ("Deinitialize Browsing Filter")
                End If
            Catch ex As Exception
                MsgBox("There was an error reading the filter configuration file")
            End Try
        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Private Browsing.txt") Then
            Try
                Dim sr_Private_Browsing As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "\Private Browsing" + ".txt")
                If sr_Private_Browsing.ReadLine = ("True") Then
                    Private_Browsing_Toggle = True
                    Private_Browsing = True
                    Me.Initiate_Private_Browsing_Menu_Item.Text = ("Deinitialize Private Browsing")
                    sr_Private_Browsing.Close()
                    Private_Browsing_On_Startup = True
                End If
            Catch ex As Exception
                MsgBox("There was an error reading the private browsing configuration file")
            End Try
        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Clear History.txt") Then
            Try
                Dim sr_Clear_History As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "\Clear History" + ".txt")
                If sr_Clear_History.ReadLine = ("true") Then
                    sr_Clear_History.Close()
                    Clear_History_On_Shutdown = True
                End If
            Catch ex As Exception
                MsgBox("There was an error reading the clear history configuration file")
            End Try
        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Bookmarks Bar.txt") Then
           
        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/XNotes.txt") Then
            Try
                Dim sr_XNotes As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "\XNotes" + ".txt")
                While sr_XNotes.EndOfStream = False
                    Current_User_Notes = Current_User_Notes + (sr_XNotes.ReadLine + vbNewLine)
                End While
                sr_XNotes.Close()
            Catch ex As Exception
                MsgBox("There was an error reading the XNotes configuration file")
        End Try
        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Document Title.txt") Then
            Try
                Dim sr_History As New StreamReader(Application.StartupPath.ToString + "/Users/" + Current_User + "\History.txt")
                Dim sr_Document_Title As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "\Document Title" + ".txt")
                While sr_Document_Title.EndOfStream = False
                    Me.History_Menu.DropDownItems.Add(sr_Document_Title.ReadLine).ToolTipText = sr_History.ReadLine
                End While
                sr_History.Close()
                sr_Document_Title.Close()
            Catch ex As Exception
                MsgBox("There was an error reading the document title configuration file" + ex.ToString)
            End Try
        Else
            Load_Failed = True
        End If
        If Load_Failed = True Then
            Recover()
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Document Title2.txt") Then
            Try
                Dim sr_DocumentTitle2 As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "/Document Title2" + ".txt")
                Dim sr_Bookmarks As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "/Bookmarks.txt")
                While sr_DocumentTitle2.EndOfStream = False
                    Bookmarks_Menu.DropDownItems.Add(sr_DocumentTitle2.ReadLine).ToolTipText = (sr_Bookmarks.ReadLine)
                End While
                sr_DocumentTitle2.Close()
            Catch ex As Exception
                MsgBox("There was an error reading the document text2 configuration file")
            End Try
        Else
            Load_Failed = True
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "/Document Title3.txt") Then
            Try
                Dim sr_DocumentTitle3 As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "/Document Title3" + ".txt")
                Dim sr_Bookmarks_Bar As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "/Bookmarks Bar.txt")
                While sr_DocumentTitle3.EndOfStream = False
                    Dim Button As System.Windows.Forms.ToolStripButton
                    Button = New System.Windows.Forms.ToolStripButton()
                    Button.Size = New System.Drawing.Size(70, 30)
                    Button.Text = sr_DocumentTitle3.ReadLine
                    Button.ToolTipText = sr_Bookmarks_Bar.ReadLine
                    ToolStrip3.Items.Add(Button)
                End While
                sr_Bookmarks_Bar.Close()
                sr_DocumentTitle3.Close()
            Catch ex As Exception
                MsgBox("There was an error reading the bookmarks bar configuration file")
            End Try
        Else
            Load_Failed = True
        End If
        If Load_Failed = True Then
            Recover()
        End If
        Return Nothing
    End Function

#End Region

#Region "Process Start"

    Private Sub ProcessStartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Process_Start As String = InputBox("Enter a process to start, " + Current_User + ".")
        If Process_Start = ("") Then
            MsgBox("You have not entered a process, " + Current_User + "!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(Process_Start)
            Catch ex As Exception
                MsgBox("Process was not found, " + Current_User + "!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

#End Region

#Region "Search"

    Function Search()
        Dim Xtreme_Browser As New Xtreme_Browser
        Dim Search_Term As String = Navigation_box.Text.Replace(" ", "+")
        Xtreme_Browser = Me.TabControl1.SelectedTab.Tag
        If (Search_Term.Contains("http://") OrElse (Search_Term.Contains("www") Or (Search_Term.Contains(".com") Or (Search_Term.Contains(".co.uk") Or (Search_Term.Contains(".edu") Or (Search_Term.Contains(".net") Or (Search_Term.Contains(".gov") Or (Search_Term.Contains(".org") Or (Search_Term.Contains(".biz")))))))))) Then
            Xtreme_Browser.Navigate(Search_Term)
        ElseIf (Search_Term.Contains(":\")) Then
            Try
                Search_Term = Navigation_box.Text.Replace("+", " ")
                File_Open = True
                Xtreme_Browser.DocumentText = System.IO.File.ReadAllText(Search_Term)
                Me.Text = ("Xtreme Browser User: " & Current_User & ", " & Search_Term)
                TabControl1.SelectedTab.Text = (Search_Term)
                Navigation_box.Text = (Search_Term)
            Catch ex As Exception
                MsgBox("An unhandled exception has occured. The error is as follows." + vbNewLine + ex.ToString)
            End Try
        Else
            If Current_User_Search_Engine = "Google" Then
                Const Google_Search As String = ("http://www.google.com/search?hl=en&q=")
                Xtreme_Browser.Navigate(Google_Search + Search_Term)
            ElseIf Current_User_Search_Engine = "Bing" Then
                Const Bing_Search As String = "http://www.bing.com/search?q="
                Xtreme_Browser.Navigate(Bing_Search + Search_Term)
            ElseIf Current_User_Search_Engine = "Yahoo" Then
                Const Yahoo_Search As String = ("http://uk.search.yahoo.com/search?vc=&p=")
                Xtreme_Browser.Navigate(Yahoo_Search + Search_Term)
            ElseIf Current_User_Search_Engine = "AOL" Then
                Const AOL_Search As String = "http://search.aol.co.uk/aol/search?s_it=hf_aoluk_po_ws40&q="
                Xtreme_Browser.Navigate(AOL_Search + Search_Term)
            ElseIf Current_User_Search_Engine = "Wikipedia" Then
                Const Wiki_Search As String = "http://en.wikipedia.org/wiki/Special:Search?search="
                Xtreme_Browser.Navigate(Wiki_Search + Search_Term)
            ElseIf Current_User_Search_Engine = ("Ebay") Then
                Const Ebay_Search As String = "http://shop.ebay.co.uk/i.html?_nkw="
                Xtreme_Browser.Navigate(Ebay_Search + Search_Term)
            ElseIf Current_User_Search_Engine = "Ask" Then
                Const Ask_Search As String = "http://uk.ask.com/web?q="
                Xtreme_Browser.Navigate(Ask_Search + Search_Term)
            ElseIf Current_User_Search_Engine = "Youtube" Then
                Const Youtube_Search As String = "http://www.youtube.com/results?search_query="
                Xtreme_Browser.Navigate(Youtube_Search + Search_Term)
            End If
        End If
        Return Nothing
    End Function

    Private Sub Search_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search_btn.Click
        Search()
    End Sub

    Private Sub Navigation_box_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Navigation_box.KeyDown
        If e.Control And e.KeyCode = Keys.A Then
            Navigation_box.SelectAll()
        ElseIf e.KeyCode = Keys.Enter Then
            Search_btn.PerformClick()
        End If
    End Sub

#End Region

#Region "Toolstrip1 Items"

#Region "File Menu"

    Private Sub New_Window_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_Window_Menu_Item.Click
        Dim New_Application_Instance As New XtremeBrowser
        New_Application_Instance.Show()
        App_Instance += 1
    End Sub

    Private Sub New_Tab_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_Tab_Menu_Item.Click
        AddTab(Current_User_Homepage, TabControl1)
    End Sub

    Private Sub Remove_Tab_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove_Tab_Menu_Item.Click
        If TabControl1.TabCount <= 1 Then
            MsgBox("Cannot close last tab.", MsgBoxStyle.Critical)
        Else
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
            Dim Xtreme_Browser As New Xtreme_Browser
            Xtreme_Browser = TabControl1.SelectedTab.Tag
            Me.Text = ("Xtreme Browser User: " & Current_User & ", " & Xtreme_Browser.DocumentTitle)
        End If
    End Sub

    Private Sub Open_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Open_Menu_Item.Click
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = TabControl1.SelectedTab.Tag
        Dim ofd As New OpenFileDialog
        ofd.FileName = ""
        ofd.Filter = "Webpages|*.html|All Files|*.*"
        ofd.Title = "Open Webpage"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            File_Open = True
            Xtreme_Browser.DocumentText = System.IO.File.ReadAllText(ofd.FileName)
            Me.Text = ("Xtreme Browser User: " & Current_User & ", " & ofd.FileName)
            TabControl1.SelectedTab.Text = (ofd.FileName)
            Navigation_box.Text = (ofd.FileName.ToString)
        End If
    End Sub

    Private Sub Save_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Menu_Item.Click
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = TabControl1.SelectedTab.Tag
        Dim sfd As New SaveFileDialog
        sfd.FileName = ""
        sfd.Filter = "Webpages|*.html|All Files|*.*"
        sfd.Title = "Save Webpage"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sw_Save_File_Dialog As New StreamWriter(sfd.FileName)
            sw_Save_File_Dialog.WriteLine(Xtreme_Browser.DocumentText)
            sw_Save_File_Dialog.Flush()
            sw_Save_File_Dialog.Close()
        End If
    End Sub

    Private Sub Print_Preview_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print_Preview_Menu_Item.Click

    End Sub

    Private Sub Print_Options_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Print_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print_Menu_Item.Click
    End Sub

    Private Sub Logout_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout_Menu_Item.Click
        If Clear_History_On_Shutdown = True Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath.ToString + "/Users/" + Current_User + "/History.txt")
            Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "History.txt")
            sw_History.Flush()
            sw_History.Close()
        End If
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Exit_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Menu_Item.Click
        If App_Instance = 0 Then
            If Clear_History_On_Shutdown = True Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath.ToString + "/Users/" + Current_User + "/History.txt")
                Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "History.txt")
                sw_History.Flush()
                sw_History.Close()
            End If
            Me.Close()
        Else
            App_Instance -= 1
        End If
    End Sub

#End Region

#Region "Edit Menu"

    Private Sub Undo_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Redo_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ToolStrip_Cut_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip_Cut_Menu_Item.Click
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = TabControl1.SelectedTab.Tag
        Dim Selected_Text As String = Xtreme_Browser.SelectedText
        If Xtreme_Browser.SelectedText <> ("") Then
            Clipboard.SetText(Selected_Text)
            Cut = True
        End If
    End Sub

    Private Sub Copy_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy_Menu_Item.Click
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = TabControl1.SelectedTab.Tag
        Dim Selected_Text As String = Xtreme_Browser.SelectedText
        If Xtreme_Browser.SelectedText <> ("") Then
            Clipboard.SetText(Selected_Text)
        End If
    End Sub

    Private Sub Paste_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paste_Menu_Item.Click
        If Clipboard.GetText <> ("") Then
            If Cut = True Then
                ActiveControl.Text = Clipboard.GetText
                Dim Xtreme_Browser As New Xtreme_Browser
                Xtreme_Browser = TabControl1.SelectedTab.Tag
                Clipboard.Clear()
                Cut = False
            Else
                ActiveControl.Text = Clipboard.GetText
                Dim Xtreme_Browser As New Xtreme_Browser
                Xtreme_Browser = TabControl1.SelectedTab.Tag
            End If
        End If
    End Sub

    Private Sub Delete_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_Menu_Item.Click
        If Clipboard.GetText <> "" Then
            Clipboard.Clear()
        End If
        If Navigation_box.SelectedText <> "" Then
            Navigation_box.SelectedText = ("")
        End If
    End Sub

    Private Sub Select_All_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select_All_Menu_Item.Click

    End Sub

    Private Sub Find_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find_Menu_Item.Click
        Dim FindText As String = InputBox("Enter a text string to find in the browser document")
        Dim Xtreme_Browser As New Xtreme_Browser
        If Xtreme_Browser.Document.TextContent.Contains(FindText) Then
            MsgBox(FindText + " found")
        End If
    End Sub

#End Region

#Region "Tools Menu"
    Private Sub Initiate_Private_Browsing_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Initiate_Private_Browsing_Menu_Item.Click
        If Private_Browsing_Toggle = True Then
            Private_Browsing = True
            MsgBox("Private Browsing Initiated by user " + Current_User + " at " + Current_Time)
            Me.Initiate_Private_Browsing_Menu_Item.Text = ("Deinitialize Private Browsing")
            Private_Browsing_Toggle = False
        Else
            MsgBox("Private browsing deinitialized")
            Me.Initiate_Private_Browsing_Menu_Item.Text = ("Initiate Private Browsing")
            Private_Browsing_Toggle = True
            Private_Browsing = False
        End If
    End Sub

    Private Sub Initiate_Browsing_Filter_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Initiate_Browsing_Filter_Menu_Item.Click
        If Browsing_Filter_Toggle = True Then
            Browsing_Filter = True
            MsgBox("Browsing Filter Initiated by user " + Current_User + " at " + Current_Time)
            Me.Initiate_Browsing_Filter_Menu_Item.Text = ("Deinitialize Browsing Filter")
            Browsing_Filter_Toggle = False
        Else
            Browsing_Filter = False
            MsgBox("Browsing Filter Deinitialized")
            Me.Initiate_Browsing_Filter_Menu_Item.Text = ("Initiate Browsing Filter")
            Browsing_Filter_Toggle = True
        End If
    End Sub

    Private Sub Clear_Browsing_History_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Browsing_History_Menu_Item.Click
        Dim Confirm As Integer
        Confirm = MsgBox(Prompt:="Are you sure you would like to clear your history " + Current_User + ".", Buttons:=vbYesNo)
        If Confirm = vbYes Then
            If My.Computer.FileSystem.FileExists(Application.StartupPath + "/Users/" + Current_User + "\History" + ".txt") Then
                Try
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath.ToString + "/Users/" + Current_User + "\History" + ".txt")
                    Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\History" + ".txt")
                    sw_History.Flush()
                    sw_History.Close()
                    MsgBox("History cleared at " + Current_Time + ".")
                Catch ex As Exception
                    MsgBox("There was a problem opening the history configuration file." + ex.ToString)
                End Try
            Else
                Recover()
            End If
        End If
    End Sub

    Private Sub Lock_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lock_Menu_Item.Click
        Lock.Show()
    End Sub

    Private Sub Calculator_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Process_Start_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process_Start_Menu_Item.Click
        Dim Process_Start As String = InputBox("Enter a process to start, " + Current_User + ".")
        If Process_Start = ("") Then
            MsgBox("You have not entered a process, " + Current_User + "!", MsgBoxStyle.Critical)
        Else
            Try
                Process.Start(Process_Start)
            Catch ex As Exception
                MsgBox("Process was not found, " + Current_User + "!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Preferences_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Preferences_Menu_Item.Click
        Preferences.Show()
    End Sub

#End Region

#Region "View Menu"

    Private Sub Source_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        View_Source.Show()
    End Sub

#End Region

#Region "Bookmarks"

    Private Sub Bookmark_This_Page_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bookmark_This_Page_Menu_Item.Click
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = TabControl1.SelectedTab.Tag

        Dim settingsList As IList
        Dim settings() As String
        Dim index As Integer = 0
        Dim firstBounds As Integer = 0
        Dim secondBounds As Integer = 0

        Dim sr_Settings As New StreamReader(Application.StartupPath + "/Users/" + Current_User + "/Settings.ini")

        While sr_Settings.EndOfStream = False
            settings(index) = sr_Settings.ReadLine
            index += 1
        End While

        sr_Settings.Close()

        index = 0

        For Each item In settings
            If item.ToString <> "" Then
                If item.ToString.Contains("Bookmarks Bar:") Then
                    firstBounds = index - 1
                ElseIf item.ToString.Contains("Bookmarks Bar Document Title:") Then
                    secondBounds = index + 1
                End If
            End If
            index += 1
        Next

        index = 0

        For Each item In settings
            If index = secondBounds Then
                settingsList.Add(Xtreme_Browser.Url.ToString)
            End If
            settingsList.Add(item.ToString)
            index += 1
        Next

        For Each item In settingsList
            MsgBox(item)
        Next

        Me.Bookmarks_Menu.DropDownItems.Add(Xtreme_Browser.DocumentTitle).ToolTipText = Current_Url
        Dim sw_Bookmarks As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Bookmarks" + ".txt", True)
        sw_Bookmarks.WriteLine(Current_Url)
        sw_Bookmarks.Flush()
        sw_Bookmarks.Close()
        Dim sw_Document_Title2 As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Document Title2" + ".txt", True)
        sw_Document_Title2.WriteLine(Xtreme_Browser.DocumentTitle)
        sw_Document_Title2.Flush()
        sw_Document_Title2.Close()
    End Sub

    Private Sub Organise_Bookmarks_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Organise_Bookmarks_Menu_Item.Click
        Organise_Bookmarks.Show()
    End Sub

#End Region

#Region "History Menu"

    Private Sub Back_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Menu_Item.Click
        Back_btn.PerformClick()
    End Sub

    Private Sub Forward_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Forward_Menu_Item.Click
        Forward_btn.PerformClick()
    End Sub

    Private Sub Home_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home_Menu_Item.Click
        Home_btn.PerformClick()
    End Sub

    Private Sub Show_All_History_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Show_All_History_Menu_Item.Click
        Show_All_History.Show()
    End Sub

#End Region

#End Region

#Region "Toolstrip2 Items"

    Private Sub Back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_btn.Click
        On Error Resume Next
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = Me.TabControl1.SelectedTab.Tag
        Xtreme_Browser.GoBack()
    End Sub

    Private Sub Forward_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Forward_btn.Click
        On Error Resume Next
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = Me.TabControl1.SelectedTab.Tag
        Xtreme_Browser.GoForward()
    End Sub

    Private Sub Stop_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stop_btn.Click
        On Error Resume Next
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = Me.TabControl1.SelectedTab.Tag
        Xtreme_Browser.Stop()
    End Sub

    Private Sub Refresh_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh_btn.Click
        On Error Resume Next
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = Me.TabControl1.SelectedTab.Tag
        Xtreme_Browser.Refresh()
    End Sub

    Private Sub Home_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home_btn.Click
        On Error Resume Next
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = Me.TabControl1.SelectedTab.Tag
        Xtreme_Browser.Navigate(Current_User_Homepage)
    End Sub

    Private Sub Lock_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Lock.Show()
    End Sub

    Private Sub Minimize_To_Tray_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        NotifyIcon.Text = ("Xtreme Browser, Current User: " + Current_User)
        NotifyIcon.Visible = True
    End Sub

    Private Sub New_Window_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim New_Application_Instance As New XtremeBrowser
        New_Application_Instance.Show()
        App_Instance += 1
    End Sub

#End Region

#Region "Bookmarks"

    Private Sub Bookmarks_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Xtreme_Browser As New Xtreme_Browser
        Bookmarks_Menu.DropDownItems.Add(Current_Url)
        Dim sw_Bookmarks As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\Bookmarks" + ".txt", True)
        sw_Bookmarks.WriteLine(Current_Url)
        sw_Bookmarks.Flush()
        sw_Bookmarks.Close()
    End Sub

    Private Sub Bookmarks_Menu_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Bookmarks_Menu.DropDownItemClicked
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = Me.TabControl1.SelectedTab.Tag
        Xtreme_Browser.Navigate(e.ClickedItem.ToolTipText)
    End Sub

#End Region

#Region "History"

    Private Sub History_Menu_DropDownItemClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles History_Menu.DropDownItemClicked
        If e.ClickedItem.ToolTipText <> "" Then
            If Not e.ClickedItem.ToolTipText.Contains(":\") Then
                Dim Xtreme_Browser As New Xtreme_Browser
                Xtreme_Browser = Me.TabControl1.SelectedTab.Tag
                Xtreme_Browser.Navigate(e.ClickedItem.ToolTipText)
            Else
                Dim Xtreme_Browser As New Xtreme_Browser
                Xtreme_Browser = Me.TabControl1.SelectedTab.Tag
                File_Open = True
                Navigation_box.Text = (e.ClickedItem.ToString)
                TabControl1.SelectedTab.Text = (e.ClickedItem.ToString)
                Me.Text = ("Xtreme Browser User: " & Current_User & ", " & e.ClickedItem.ToString)
                Xtreme_Browser.DocumentText = System.IO.File.ReadAllText(e.ClickedItem.ToString)
            End If
        End If
    End Sub

#End Region

#Region "Ungrouped Events"

    Private Sub Tom_Browser_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Msg <> "" Then
            MsgBox("Message left by " & Msg_User & " at " & Current_Time & " Message contains: " & Msg)
            Msg = ("")
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        NotifyIcon.Visible = False
        Me.Show()
    End Sub

#End Region

    Private Sub XPad_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XPad_Menu_Item.Click
        XPad.Show()
    End Sub

    Private Sub Minimize_To_Tray_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimize_To_Tray_Menu_Item.Click
        Me.Hide()
        NotifyIcon.Text = ("Xtreme Browser, Current User: " + Current_User)
        NotifyIcon.Visible = True
    End Sub

    Private Sub View_Source_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        View_Source.Show()
    End Sub

    Private Sub CMDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDToolStripMenuItem.Click
        Try
            Process.Start("cmd.exe")
        Catch
            MsgBox("CMD cannot be started and may be disabled.")
        End Try
    End Sub

    Private Sub NavigationToolbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Navigation_Toolbar_Menu_Item.Click
        If Navigation_Toolbar_Menu_Item.Checked = True Then
            ToolStrip2.Visible = False
            Navigation_Toolbar_Menu_Item.Checked = False
        Else
            ToolStrip2.Visible = True
            Navigation_Toolbar_Menu_Item.Checked = True
        End If
    End Sub

    Private Sub Xtreme_Browser_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If App_Instance = 0 Then
            If Clear_History_On_Shutdown = True Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath.ToString + "/Users/" + Current_User + "/History.txt")
                Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/History.txt")
                sw_History.Flush()
                sw_History.Close()
            End If
        End If
    End Sub

    Private Sub Shutdown_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shutdown_Timer.Tick
        System.Diagnostics.Process.Start("shutdown", "-s -f")
    End Sub

    Private Sub Timed_Shutdown_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timed_Shutdown_Menu_Item.Click
        If Shutdown_Toggle = True Then
            Shutdown_Timer.Stop()
            MsgBox("Shutdown Canceled")
            Timed_Shutdown_Menu_Item.Image = My.Resources.Shutdown_Timer_btn
            Shutdown_Toggle = False
            Timed_Shutdown_Menu_Item.Text = ("Timed Shutdown")
        Else
            Timed_Shutdown.Show()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.Show()
    End Sub


    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        About.Show()
    End Sub

    Private Sub BookmarksToolbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bookmarks_Toolbar_Menu_Item.Click
        If Bookmarks_Toolbar_Menu_Item.Checked = True Then
            ToolStrip3.Visible = False
            Bookmarks_Toolbar_Menu_Item.Checked = False
        Else
            ToolStrip3.Visible = True
            Bookmarks_Toolbar_Menu_Item.Checked = True
        End If
    End Sub

    Private Sub ToolStrip3_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip3.ItemClicked
        Dim Xtreme_Browser As New Xtreme_Browser
        Xtreme_Browser = TabControl1.SelectedTab.Tag
        Xtreme_Browser.Navigate(e.ClickedItem.ToolTipText)
    End Sub

    Private Sub AddToBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToBarToolStripMenuItem.Click
            Try
            Dim Xtreme_Browser As New Xtreme_Browser
            Xtreme_Browser = TabControl1.SelectedTab.Tag
            Dim sw_Bookmars_Bar As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Bookmarks Bar.txt", True)
                sw_Bookmars_Bar.WriteLine(Current_Url)
                sw_Bookmars_Bar.Flush()
            sw_Bookmars_Bar.Close()
            Dim sw_Document_Title3 As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "/Document Title3.txt", True)
            sw_Document_Title3.WriteLine(Xtreme_Browser.DocumentTitle)
            sw_Document_Title3.Flush()
            sw_Document_Title3.Close()
                Dim Button As System.Windows.Forms.ToolStripButton
                Button = New System.Windows.Forms.ToolStripButton()
                Button.Size = New System.Drawing.Size(70, 30)
            Button.Text = Xtreme_Browser.DocumentTitle
            Button.ToolTipText = Current_Url
            ToolStrip3.Items.Add(Button)
            Catch
                MsgBox("There was a problem writing to the bookmarks bar configuration file.")
            End Try
    End Sub

    Private Sub Save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Lock_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lock_btn.Click
        Lock_Menu_Item.PerformClick()
    End Sub

    Private Sub View_Source_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View_Source_btn.Click
        View_Source_Menu_Item.PerformClick()
    End Sub

    Private Sub Minimize_To_Tray_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Minimize_To_Tray_Menu_Item.PerformClick()
    End Sub

    Private Sub View_Source_Menu_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View_Source_Menu_Item.Click
        View_Source.Show()
    End Sub

    Private Sub NotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotesToolStripMenuItem.Click
        XNotes.Show()
    End Sub

    Private Sub TabControl1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Tools_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tools_Menu.Click

    End Sub

    Private Sub Bookmark_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bookmark_btn.Click
        Bookmarks_Toolbar_Menu_Item.PerformClick()
    End Sub
End Class

Public Class Xtreme_Browser
    Inherits webkit.WebKitBrowser

#Region "Document Completed"

    Public Sub DocCompleted() Handles Me.DocumentCompleted
        XtremeBrowser.ToolStrip1.Enabled = True
        XtremeBrowser.ToolStrip2.Enabled = True
        XtremeBrowser.ToolStrip3.Enabled = True
        If XtremeBrowser.File_Open = False Then
            If XtremeBrowser.App_Instance <> 0 Then
                Dim New_Application_Instance As New XtremeBrowser
                If XtremeBrowser.Browsing_Filter = True Then
                    Current_Url = Me.Url.ToString
                End If
                Current_Url = Me.Url.ToString
                Dim TP As TabPage = Me.Tag
                If Me.DocumentTitle.Length > 10 Then
                    TP.Text = Me.DocumentTitle.Substring(0, 9) & "..."
                    New_Application_Instance.Text = ("Xtreme Browser User: " & Current_User & ", " & Me.DocumentTitle)
                    New_Application_Instance.Navigation_box.Text = (Current_Url)
                Else
                    TP.Text = Me.DocumentTitle
                    New_Application_Instance.Text = ("Xtreme Browser User: " & Current_User & ", " & Me.DocumentTitle)
                    New_Application_Instance.Navigation_box.Text = (Current_Url)
                End If
                New_Application_Instance.Navigation_box.Items.Add(Current_Url)
                If XtremeBrowser.Private_Browsing = False Then
                    New_Application_Instance.History_Menu.DropDownItems.Add(Current_Url)
                    New_Application_Instance.Navigation_box.Text = (Current_Url)
                    Dim sw As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\History" + ".txt", True)
                    sw.WriteLine(Current_Url)
                    sw.Flush()
                    sw.Close()
                End If
            Else
                If XtremeBrowser.Browsing_Filter = True Then
                    Current_Url = Me.Url.ToString
                End If
                Current_Url = Me.Url.ToString
                Dim TP As TabPage = Me.Tag
                If Me.DocumentTitle.Length > 10 Then
                    TP.Text = Me.DocumentTitle.Substring(0, 9) & "..."
                    XtremeBrowser.Text = ("Xtreme Browser User: " & Current_User & ", " & Me.DocumentTitle)
                    XtremeBrowser.Navigation_box.Text = (Current_Url)
                Else
                    TP.Text = Me.DocumentTitle
                    XtremeBrowser.Text = ("Xtreme Browser User: " & Current_User & ", " & Me.DocumentTitle)
                    XtremeBrowser.Navigation_box.Text = (Current_Url)
                End If
                XtremeBrowser.Navigation_box.Items.Add(Current_Url)
                If XtremeBrowser.Private_Browsing = False Then
                    XtremeBrowser.History_Menu.DropDownItems.Add(Me.DocumentTitle).ToolTipText = XtremeBrowser.Navigation_box.Text
                    Try
                        Dim sw_Document_Title As New StreamWriter(Application.StartupPath + "/Users/" + Current_User + "/Document Title.txt", True)
                        sw_Document_Title.WriteLine(Me.DocumentTitle)
                        sw_Document_Title.Flush()
                        sw_Document_Title.Close()
                    Catch ex As Exception
                        MsgBox("An error occured reading the document title configuration file.")
                    End Try
                    Try
                        Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\History" + ".txt", True)
                        sw_History.WriteLine(XtremeBrowser.Navigation_box.Text.ToString)
                        sw_History.Flush()
                        sw_History.Close()
                    Catch
                        MsgBox("An error occured reading the history configuration file.")
                    End Try
                End If
            End If
            Dim Url As Uri = New Uri(XtremeBrowser.Navigation_box.Text)
            If Url.HostNameType = UriHostNameType.Dns Then
                Dim Icon_Url As String
                Try
                    Icon_Url = "http://" + Url.Host + "/favicon.ico"
                    Dim Request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(Icon_Url)
                    Dim Response As System.Net.HttpWebResponse = Request.GetResponse
                    Dim Stream As System.IO.Stream = Response.GetResponseStream
                    Dim favicon = Image.FromStream(Stream)
                    XtremeBrowser.Favicon.Image = (favicon)
                    XtremeBrowser.Favicon.ToolTipText = (Me.DocumentTitle)
                    XtremeBrowser.Favicon.Visible = True
                Catch
                    Try
                        Icon_Url = "http://" + Url.Host + "/Images/favicon.ico"
                        Dim Request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(Icon_Url)
                        Dim Response As System.Net.HttpWebResponse = Request.GetResponse
                        Dim Stream As System.IO.Stream = Response.GetResponseStream
                        Dim favicon = Image.FromStream(Stream)
                        XtremeBrowser.Favicon.Image = (favicon)
                        XtremeBrowser.Favicon.ToolTipText = (Me.DocumentTitle)
                        XtremeBrowser.Favicon.Visible = True
                    Catch
                        XtremeBrowser.Favicon.Visible = False
                    End Try
                End Try
            End If
        Else
            XtremeBrowser.File_Open = False
            XtremeBrowser.History_Menu.DropDownItems.Add(Me.DocumentTitle).ToolTipText = XtremeBrowser.Navigation_box.Text
            Try
                Dim sw_History As New StreamWriter(Application.StartupPath.ToString + "/Users/" + Current_User + "\History" + ".txt", True)
                sw_History.WriteLine(XtremeBrowser.Navigation_box.Text.ToString)
                sw_History.Flush()
                sw_History.Close()
            Catch
                MsgBox("An error occured reading the history configuration file.")
            End Try
        End If
    End Sub

#End Region

    Private Sub XtremeBrowser_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles Me.Navigating
        For Each File As String In My.Settings.Files
            If e.Url.ToString.EndsWith(File) Then
                Downloads.Show()
                Downloads.Url_Text_Box.Text = e.Url.ToString
            End If
        Next
    End Sub
End Class
Public Class CustomRenderer
    Inherits ToolStripSystemRenderer

    Protected Overrides Sub OnRenderToolStripBorder(ByVal e As System.Windows.Forms.ToolStripRenderEventArgs)
        'Do nothing   
    End Sub
End Class