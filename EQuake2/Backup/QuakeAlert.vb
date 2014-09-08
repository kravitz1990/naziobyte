Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Mail
Imports System.Threading
Imports TwitterVB2

Class QuakeAlert

    'Dim msg As String
    Dim tw As New TwitterAPI
    Dim smp As New SmtpClient
    Dim mail As New MailMessage

    Public Sub iQuakeAlertSettingASync(ByVal isShmsg As Boolean, ByVal isFB As Boolean, ByVal isTW As Boolean, ByVal isEmail As Boolean, ByVal isNet As Boolean, ByVal isSound As Boolean, ByVal soundmode As Integer, ByVal QuakeLevel As Double, ByVal SoundPath As String)

        isShowPersonalMessage = isShmsg
        isSendFacebookMessage = isFB
        isSendTwitterMessage = isTW
        isSendEmailMessage = isEmail
        isSendNetworkMessage = isNet
        isPlaySound = isSound
        cQuakeLevel = QuakeLevel
        playmode = soundmode
        SoundPath = SoundPath

        ' เก็บลงไฟล์ด้วย

    End Sub

    Public Sub SendPersonalMessage()

        setLastSyncData()
        isShowPersonalMessage = True

        If isShowPersonalMessage = True Then

            If Double.Parse(ari0(0)) >= cQuakeLevel Then

                Form1.Check_CellFirstLoad()
                Form1.notifyAlert.BalloonTipIcon = ToolTipIcon.Info
                Form1.notifyAlert.BalloonTipTitle = "ตรวจพบรายงานแผ่นดินไหว                        "
                Form1.notifyAlert.BalloonTipText = ("สถานที่ : " & InfoPanel.getLocation & vbCrLf & "ขนาด : " & InfoPanel.getQaukeLevel & " ริกเตอร์" & vbCrLf & "ความลึก : " & InfoPanel.getDept & vbCrLf & "เมื่อ : " & ToLocalTime(InfoPanel.getDateTime) & vbCrLf & "ผู้ประกาศ : " & FormatPubisher(InfoPanel.getPublisher))
                Form1.notifyAlert.ShowBalloonTip(50000)

                playSoundAlert()

            End If

        End If

    End Sub



    Public Sub SendFacebookMessage()

        'App ID: 238494026282229
        'App(Secret) : d2ad96bed06a2080edd8b9da72e792c0

        If isSendFacebookMessage = True Then




        End If

    End Sub



    Public Sub SendTwitterMessage()
        setLastSyncData()

        isSendTwitterMessage = True

        If isSendTwitterMessage = True Then

            tw.AuthenticateWith(consumer, consumersecret, auth1, auth2)
            tw.ReplyToUpdate("แผ่นดินไหว " & getTwLastNews(), tw.AccountInformation.ID)

        End If

    End Sub



    Public Sub SendNetworkMessage()

        If isSendNetworkMessage = True Then

        End If

    End Sub


    Public Sub SendEmailMessage()

        On Error Resume Next

        If isSendEmailMessage = True Then

            setLastSyncData()

            smp.Credentials = New Net.NetworkCredential(mailUser, mailPassword)
            mail = New MailMessage
            mail.From = New MailAddress(mailUser)

            For n = 0 To xBuild.Count - 1
                mail.To.Add(xBuild(n))
            Next

            mail.Subject = "แจ้งเตือนแผ่นดินไหว"
            mail.Body = "แผ่นดินไหว " & InfoPanel.getLocation & " ขนาด: " & InfoPanel.getQaukeLevel & " ริกเตอร์  เมื่อ: " & UTCToLocaltime.ToLocalTime(InfoPanel.getDateTime) & vbCrLf & InfoPanel.getURL


            smp.EnableSsl = SSL
            smp.Host = HOST
            smp.Port = PORT

            smp.Send(mail)

        End If


    End Sub

    Private Sub playSoundAlert()


        If isPlaySound = True Then

            My.Computer.Audio.Play(soundPath, playmode)

        End If

    End Sub

    Public Sub distroySystemTray()

        Form1.notifyAlert.Visible = False
        Form1.notifyAlert.Dispose()
        Form1.notifyAlert = Nothing

    End Sub

    Private Sub setLastSyncData()

        InfoPanel.setQaukeLevel(ari0(0))
        InfoPanel.setDept(ari1(0))
        InfoPanel.setLat_Long(ari2(0))
        InfoPanel.setLocation(ari3(0))
        InfoPanel.setDateTime(ari4(0))
        InfoPanel.setPublisher(ari5(0))
        InfoPanel.setURL(ari6(0))

    End Sub

    Private Function getTwLastNews() As String

        Return InfoPanel.getLocation & "ขนาด : " & InfoPanel.getQaukeLevel & " ริกเตอร์" & "ลึก " & InfoPanel.getDept & "เมื่อ " & ToLocalTime(InfoPanel.getDateTime) & " (" & InfoPanel.getPublisher & ")"

    End Function

End Class
