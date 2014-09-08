
'Imports IWshRuntimeLibrary
Public Class frmConfig

    Dim soundMode As Integer
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

        txtTrackVal.Text = TrackBar1.Value & ".0"
        Button1.Enabled = True
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSound.Click
        ContextMenuStrip1.Show(Cursor.Position)
    End Sub

    Private Sub frmConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadSoundsFile()
        LoadSetting()


    End Sub


    Public Sub ApplySetting()

        playmode = soundMode
        isPlayLoop = chkIsSoundLoop.Checked
        isShowPersonalMessage = chkShowPopup.Checked
        isPlaySound = chkSound.Checked
        isStartUp = chkStartUp.Checked
        isTSunamiMode = chkTsunami.Checked
        cQuakeLevel = Double.Parse(TrackBar1.Value & ".0")
        soundPath = ListSound.Text


        'ax_mail_by = txtgetMail.Text
        'ax_mail_lastActive = txtgetDateMail.Text
        'ax_mail_EQ = txtRitcher.Text
        'ax_mail_userFollow = txtCountSenderMail.Text

        'ax_ip4_by = txtgetIPv4.Text
        'ax_ip4_CountHost = txtCountHost.Text
        'ax_ip4_EQLevel = txtNetEQ.Text

        'ax_twit_by = txtTwuser.Text
        'ax_twit_lastActive = txtDateTw.Text
        'ax_twit_follow = txtTwCountFollow.Text
        'ax_twit_EQLevel = txtTwEQ.Text

        HIndex = EmailManage.ComboBox1.SelectedIndex

        My.Computer.Audio.Stop()


        If isTSunamiMode = True Then

            Form1.TsunamiIco.Visible = True
        Else
            Form1.TsunamiIco.Visible = False

        End If



        If isSendEmailMessage = False Then

            PORT = 0
            HOST = "NULL"
            SSL = False

        End If


        CheckSoundButtonPlayer()

    End Sub

    Private Sub LoadSetting()


        chkSound.Checked = isPlaySound
        chkShowPopup.Checked = isShowPersonalMessage
        soundMode = playmode
        chkStartUp.Checked = isStartUp
        chkIsSoundLoop.Checked = isPlayLoop
        chkTsunami.Checked = isTSunamiMode

        If isSendEmailMessage = True Then

            setMailGreenFont()
            txtgetMail.Text = ax_mail_by
            txtgetDateMail.Text = ax_mail_lastActive
            txtRitcher.Text = ax_mail_EQ
            txtCountSenderMail.Text = ax_mail_userFollow

        Else
            UnsetMailGreenFont()
        End If


        ' If isSendNetworkMessage = True Then

        'setNetworkGreenFont()
        'txtgetIPv4.Text = ax_ip4_by
        ' txtCountHost.Text = ax_ip4_CountHost
        ' txtNetEQ.Text = ax_ip4_EQLevel
        'Else

        '  UnsetNetworkGreenFont()

        ' End If

        '   If isSendTwitterMessage = True Then

        'setTwitterGreenFont()

        '  txtTwuser.Text = ax_twit_by
        '  txtDateTw.Text = ax_twit_lastActive
        ' txtTwCountFollow.Text = ax_twit_follow
        ' txtTwEQ.Text = ax_twit_EQLevel
        ' Else

        'UnsetTwitterGreenFont()
        ' End If


        CheckSoundButtonPlayer()
        TrackBar1.Value = Mid(cQuakeLevel, 1, 1)
        txtTrackVal.Text = cQuakeLevel & ".0"

        ListSound.Text = soundPath
        Button1.Enabled = False


    End Sub


    Public Sub LoadSoundsFile()

        Try
            ListSound.Items.Clear()
            Dim td As New IO.DirectoryInfo(CurDir() & "\sounds")
            For Each curWave In td.GetFiles
                ListSound.Items.Add(curWave)
            Next

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Close()
        End Try

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Force
        ' If isSendNetworkMessage = True Then
        '  txtNetEQ.Text = txtTrackVal.Text & " ริกเตอร์ขึ้นไป"

        '  End If

        '   If isSendTwitterMessage = True Then
        'txtTwEQ.Text = txtTrackVal.Text & " ริกเตอร์ขึ้นไป"
        '  End If



        ApplySetting()
        Apply_startUp()
        iSaveSettingAsync()
        Button1.Enabled = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ApplySetting()
        Apply_startUp()
        iSaveSettingAsync()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSound.CheckedChanged
        Button1.Enabled = True
        CheckSoundButtonPlayer()

    End Sub


    Private Sub CheckSoundButtonPlayer()

        If chkSound.Checked = True Then

            btnStop.Enabled = False
            btnplay.Enabled = True
            ListSound.Enabled = True
            btnAddSound.Enabled = True


        ElseIf chkSound.Checked = False Then

            btnStop.Enabled = False
            btnplay.Enabled = False
            ListSound.Enabled = False
            btnAddSound.Enabled = False
            isPlaySound = False
            ListSound.SelectedItem = Nothing


        End If

    End Sub



    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Console.WriteLine(mailAccept)

        If mailAccept = "Yes" Then
            EmailManage.ShowDialog()


        Else
            frmMailAccept.ShowDialog()

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TwitManage.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FacebookManage.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        NetworkCard.ShowDialog()

    End Sub

    Private Sub จากเวบเซรฟเวอรToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles จากเวบเซรฟเวอรToolStripMenuItem.Click
        soundDownloader.ShowDialog()
    End Sub

    Private Sub ListSound_Click(sender As Object, e As EventArgs) Handles ListSound.Click
        If btnStop.Enabled = True Then

            My.Computer.Audio.Stop()
            btnplay.Enabled = True
            btnStop.Enabled = False

        End If

    End Sub

    Private Sub ListSound_DoubleClick(sender As Object, e As EventArgs) Handles ListSound.DoubleClick

        Try
            My.Computer.Audio.Play(CurDir() & "\sounds\" & ListSound.Text, AudioPlayMode.BackgroundLoop)
            btnplay.Enabled = False
            btnStop.Enabled = True
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub ListSound_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListSound.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub btnplay_Click(sender As Object, e As EventArgs) Handles btnplay.Click

        Try
            My.Computer.Audio.Play(CurDir() & "\sounds\" & ListSound.Text, AudioPlayMode.BackgroundLoop)
            btnplay.Enabled = False
            btnStop.Enabled = True
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        My.Computer.Audio.Stop()
        btnStop.Enabled = False
        btnplay.Enabled = True
    End Sub

    Private Sub จากแฟมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles จากแฟมToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk


        If Not IO.File.Exists(CurDir() & "\sounds\" & OpenFileDialog1.SafeFileName) Then

            IO.File.Copy(OpenFileDialog1.FileName, CurDir() & "\sounds\" & OpenFileDialog1.SafeFileName)

        Else

            If MsgBox("เนื่องจากมีไฟล์เดิมอยู่แล้วคุณต้องการบันทึกซ้ำหรือไม่", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "                ") = MsgBoxResult.Ok Then

                Try
                    IO.File.Delete(CurDir() & "\sounds\" & OpenFileDialog1.SafeFileName)
                    IO.File.Copy(OpenFileDialog1.FileName, CurDir() & "\sounds\" & OpenFileDialog1.SafeFileName)

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

                End Try

            End If

        End If

        LoadSoundsFile()

    End Sub


    Private Sub chkIsSoundLoop_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsSoundLoop.CheckedChanged
        Button1.Enabled = True
        If chkIsSoundLoop.Checked = True Then

            soundMode = 2

        ElseIf chkIsSoundLoop.Checked = False Then

            soundMode = 1
        End If


    End Sub

    Private Sub chkStartUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkStartUp.CheckedChanged
        Button1.Enabled = True

    End Sub

    Private Sub chkShowPopup_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPopup.CheckedChanged
        Button1.Enabled = True
    End Sub

    Private Sub chkTsunami_CheckedChanged(sender As Object, e As EventArgs) Handles chkTsunami.CheckedChanged
        Button1.Enabled = True
    End Sub



    Public Sub setMailGreenFont()

        txtgetMail.ForeColor = Color.FromArgb(64, 64, 64)
        txtgetDateMail.ForeColor = Color.FromArgb(64, 64, 64)
        txtCountSenderMail.ForeColor = Color.FromArgb(64, 64, 64)
        txtRitcher.ForeColor = Color.FromArgb(64, 64, 64)


    End Sub

    Public Sub setTwitterGreenFont()

        txtTwuser.ForeColor = Color.FromArgb(64, 64, 64)
        txtDateTw.ForeColor = Color.FromArgb(64, 64, 64)
        txtTwCountFollow.ForeColor = Color.FromArgb(64, 64, 64)
        txtTwEQ.ForeColor = Color.FromArgb(64, 64, 64)


    End Sub


    Public Sub UnsetMailGreenFont()

        txtgetMail.ForeColor = Color.FromArgb(64, 64, 64)
        txtgetDateMail.ForeColor = Color.FromArgb(64, 64, 64)
        txtCountSenderMail.ForeColor = Color.FromArgb(64, 64, 64)
        txtRitcher.ForeColor = Color.FromArgb(64, 64, 64)


    End Sub

    Public Sub UnsetTwitterGreenFont()

        txtTwuser.ForeColor = Color.FromArgb(64, 64, 64)
        txtDateTw.ForeColor = Color.FromArgb(64, 64, 64)
        txtTwCountFollow.ForeColor = Color.FromArgb(64, 64, 64)
        txtTwEQ.ForeColor = Color.FromArgb(64, 64, 64)

    End Sub

    Public Sub setNetworkGreenFont()

        txtgetIPv4.ForeColor = Color.FromArgb(64, 64, 64)
        txtCountHost.ForeColor = Color.FromArgb(64, 64, 64)
        txtNetEQ.ForeColor = Color.FromArgb(64, 64, 64)

    End Sub

    Public Sub UnsetNetworkGreenFont()

        txtgetIPv4.ForeColor = Color.FromArgb(64, 64, 64)
        txtCountHost.ForeColor = Color.FromArgb(64, 64, 64)
        txtNetEQ.ForeColor = Color.FromArgb(64, 64, 64)

    End Sub



    Private Sub Apply_startUp()


        '  Dim startup As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)

        ' If isStartUp = True Then

        'Dim cdn As New IWshShell_Class
        'Dim StartUpShortcut As IWshRuntimeLibrary.IWshShortcut
        'StartUpShortcut = DirectCast(cdn.CreateShortcut(startup & "\EarthQuake Realtime Checker.lnk"), IWshRuntimeLibrary.IWshShortcut)
        'StartUpShortcut.WindowStyle = 1
        'StartUpShortcut.IconLocation = CurDir() & "\data\globe_vista.ico"
        'StartUpShortcut.TargetPath = Application.ExecutablePath
        'StartUpShortcut.Save()

        ' Else
        'Try
        'IO.File.Delete(startup & "\EarthQuake Realtime Checker.lnk")
        'Catch ex As Exception
        ' End Try

        ' End If

        ' ให้รันโปรแกรมตอน Startup หรือไม่
        Dim regKey As Microsoft.Win32.RegistryKey
        Dim keyName As String = "Earthquake Realtime"
        Dim keyValue As String
        regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        If isStartUp = True Then


            keyValue = """" & Process.GetCurrentProcess.MainModule.FileName & """"
            regKey.SetValue(keyName, keyValue, Microsoft.Win32.RegistryValueKind.String)
        Else

            keyValue = ""
            regKey.SetValue(keyName, keyValue, Microsoft.Win32.RegistryValueKind.String)


        End If


    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Try

            If MessageBox.Show("คุณแน่ใจหรือว่าต้องการลบไฟล์ " & ListSound.Text, "          ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

                IO.File.Delete(CurDir() & "\sounds\" & ListSound.Text)
                LoadSoundsFile()

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "                    ")
            isPlaySound = False
        End Try
       

    End Sub
End Class