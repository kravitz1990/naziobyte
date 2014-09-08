Imports System.IO

Module SettingAsync

    'ระดับที่ต้องการเตือน
    'รูปแบบเสียง 'จำนวนรอบเสียง
    'ข้อความ

    Public isShowPersonalMessage, isSendEmailMessage As Boolean
    Public isPlaySound As Boolean
    Public playmode As Integer
    Public isPlayLoop As Boolean
    Public cQuakeLevel As Double
    Public soundPath As String
    Public isTSunamiMode As Boolean
    Public isStartUp As Boolean

    Public mailUser, mailPassword As String
    Public mailAccept As String
 
    Public SSL As Boolean
    Public HOST As String
    Public PORT, HIndex As Integer
    Public ipIndex As Integer

    'Configutration external sender
    Public ax_mail_by, ax_mail_lastActive, ax_mail_userFollow, ax_mail_EQ As String
    Public ax_ip4_by, ax_ip4_CountHost, ax_ip4_EQLevel As String
    Public ax_twit_by, ax_twit_lastActive, ax_twit_follow, ax_twit_EQLevel As String


    'Config for Networking
    Public net_Host, net_Port, net_Protocol As New ArrayList

    Public Sub iLoadSettingAsync()

        'Dim confRead As StreamReader
        'confRead = File.OpenText(CurDir() & "\config.ini")

        isStartUp = My.Settings.isStartUp
        isShowPersonalMessage = My.Settings.isShowPersonalMessage
        isPlayLoop = My.Settings.isPlayLoop
        isTSunamiMode = My.Settings.isTSunamiMode
        cQuakeLevel = Double.Parse(My.Settings.cQuakeLevel)
        isPlaySound = My.Settings.isPlaySound
        soundPath = My.Settings.soundPath
        isSendEmailMessage = My.Settings.isSendEmailMessage

        SSL = My.Settings.SSL
        HOST = My.Settings.HOST
        PORT = My.Settings.PORT
        mailAccept = My.Settings.mailAccept
        HIndex = My.Settings.HIndex
        ax_mail_by = My.Settings.ax_mail_by


        'ax_mail_lastActive = confRead.ReadLine
        'ax_mail_userFollow = confRead.ReadLine
        'ax_mail_EQ = confRead.ReadLine
        'ax_ip4_by = confRead.ReadLine
        'ax_ip4_CountHost = confRead.ReadLine
        'ax_ip4_EQLevel = confRead.ReadLine
        'ax_twit_by = confRead.ReadLine
        'ax_twit_lastActive = confRead.ReadLine
        'ax_twit_follow = confRead.ReadLine
        'ax_twit_EQLevel = confRead.ReadLine
        'isSendNetworkMessage = confRead.ReadLine
        'isSendTwitterMessage = confRead.ReadLine
        'HIndex = confRead.ReadLine
        'ipIndex = confRead.ReadLine
        'confRead.Close()


        If isTSunamiMode = True Then

            Form1.TsunamiIco.Visible = True
        Else

            Form1.TsunamiIco.Visible = False

        End If



        If isSendEmailMessage = True Then


            ' Dim rd As StreamReader
            Dim xFile As String = CurDir() & "\profiles\" & ax_mail_by & ".txt"
            'Dim lines As String() = File.ReadAllLines(xFile)
            'Dim temp = CurDir() & "\profiles\temp.dat"
            'Dim dbgit = CurDir() & "\profiles\dbgid.dat"


            ' If File.Exists(xFile) Then

            ' rd = File.OpenText(xFile)
            'xBuild.Clear()
            'For i = 1 To lines.Length

            'xBuild.Add(rd.ReadLine)

            'Next
            'rd.Close()


            'DecryptFile(dbgit, Temp, "5eb8014d")
            'rd = File.OpenText(Temp)
            'mailUser = DescryptText(rd.ReadLine)
            'mailPassword = DescryptText(rd.ReadLine)
            'rd.Close()

            'File.Delete(Temp)

            EmailManage.txtUser.Text = DescryptText(My.Settings.mail_user)
            EmailManage.txtPass.Text = DescryptText(My.Settings.mail_password)
            EmailManage.txtUser.ReadOnly = True
            EmailManage.txtPass.ReadOnly = True
            EmailManage.Button2.Enabled = False
            EmailManage.ComboBox1.SelectedIndex = HIndex
            EmailManage.showInterfacelogin(True)


        End If


        ' End If




    End Sub

    Public Sub iSaveSettingAsync()

        'Dim confWrite As StreamWriter
        'confWrite = File.CreateText(CurDir() & "\config.ini")

        My.Settings.isStartUp = isStartUp
        My.Settings.isShowPersonalMessage = isShowPersonalMessage
        My.Settings.isPlayLoop = isPlayLoop
        My.Settings.isTSunamiMode = isTSunamiMode
        My.Settings.cQuakeLevel = cQuakeLevel & ".0"
        My.Settings.isPlaySound = isPlaySound
        My.Settings.soundPath = soundPath
        My.Settings.isSendEmailMessage = isSendEmailMessage
        My.Settings.SSL = SSL
        My.Settings.HOST = HOST
        My.Settings.PORT = PORT
        My.Settings.HIndex = HIndex
        My.Settings.mailAccept = mailAccept
        My.Settings.ax_mail_by = ax_mail_by
        My.Settings.Save()


        'confWrite.WriteLine(isStartUp)
        'confWrite.WriteLine(isShowPersonalMessage)
        'confWrite.WriteLine(isPlayLoop)
        'confWrite.WriteLine(isTSunamiMode)
        'confWrite.WriteLine(cQuakeLevel & ".0")
        'confWrite.WriteLine(isPlaySound)
        'confWrite.WriteLine(soundPath)
        'confWrite.WriteLine(isSendEmailMessage)
        'confWrite.WriteLine(ax_mail_by)
        'confWrite.WriteLine(ax_mail_lastActive)
        'confWrite.WriteLine(ax_mail_userFollow)
        'confWrite.WriteLine(ax_mail_EQ)
        'confWrite.WriteLine(ax_ip4_by)
        'confWrite.WriteLine(ax_ip4_CountHost)
        'confWrite.WriteLine(ax_ip4_EQLevel)
        'confWrite.WriteLine(ax_twit_by)
        'confWrite.WriteLine(ax_twit_lastActive)
        'confWrite.WriteLine(ax_twit_follow)
        'confWrite.WriteLine(ax_twit_EQLevel)
        'confWrite.WriteLine(isSendNetworkMessage)
        'confWrite.WriteLine(isSendTwitterMessage)
        'confWrite.WriteLine(SSL)
        'confWrite.WriteLine(HOST)
        'confWrite.WriteLine(PORT)
        'confWrite.WriteLine(HIndex)
        'confWrite.WriteLine(ipIndex)
        'confWrite.WriteLine(mailAccept)
        'confWrite.Close()


    End Sub

End Module
