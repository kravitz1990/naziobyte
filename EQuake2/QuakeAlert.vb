Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Mail
Imports System.Threading
Imports twitter4j
Imports twitter4j.util
Imports twitter4j.examples.tweets
Imports bitly
Imports System.Web

'Imports TwitterVB2
'Imports Facebook

Class QuakeAlert

    'Dim msg As String
    ' Dim tw As New TwitterAPI
    Dim smp As New SmtpClient
    Dim mail As New MailMessage
    Dim tcSend As TcpClient
    Dim ucSend As UdpClient
    Dim ns As NetworkStream
    Dim bb() As Byte


    Public Sub SendPersonalMessage()

        setLastSyncData()


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

        ' If isSendFacebookMessage = True Then


        'End If

    End Sub

    Public Sub SendTwitterMessage()

        On Error Resume Next

        setLastSyncData()

        Dim bitURL As String = GenerateShortLink(InfoPanel.getURL)
        Dim temp As String = "แผ่นดินไหว " & InfoPanel.getLocation & " ขนาด " & InfoPanel.getQaukeLevel & " ลึก " & InfoPanel.getDept.Replace("km", "กม.") & " เมื่อ " & ToLocalTime(InfoPanel.getDateTime).Replace(":", ".") & " " & bitURL

        If isSendTwitterMessage = True Then

            If Double.Parse(ari0(0)) >= cQuakeLevel Then

                ntw(pcy).UpdateSatus(temp)

            End If

        End If

    End Sub

    Public Function GenerateShortLink(ByVal URL As String) As String

        Dim wc = New WebClient()
        Dim login = "o_5skq6upspq"
        Dim apiKey = "R_77857a384e1b63cd1fc72bf6253eef6e"
        Dim longUrl = HttpUtility.UrlEncode(URL)
        Dim request = String.Format("http://api.bit.ly/v3/shorten?login={0}&apiKey={1}&longUrl={2}&format=txt", login, apiKey, longUrl)
        Dim result = wc.DownloadString(request)

        Return result

    End Function


    Public Sub SendNetworkMessage()


        On Error Resume Next
        setLastSyncData()

        ' If isSendNetworkMessage = True Then

        'If Double.Parse(ari0(0)) >= cQuakeLevel Then

        'For z = 0 To net_Host.Count - 1

        'Select Case net_Protocol(z)

        '   Case "TCP"

        ' tcSend = New TcpClient(net_Host(z), net_Port(z))
        ' ns = tcSend.GetStream
        ' bb = Encoding.ASCII.GetBytes(getLastNews)
        ' ns.Write(bb, 0, bb.Length)
        ' tcSend.Close()

        '   Case "UDP"

        ' ucSend.Connect(net_Host(z), net_Port(z))
        ' bb = Encoding.ASCII.GetBytes(getLastNews)
        ' ucSend.Send(bb, bb.Length)
        ' ucSend.Close()


        '  End Select

        ' Next

        ' End If

        ' End If

    End Sub


    Public Sub SendEmailMessage()

        On Error Resume Next

        If Double.Parse(ari0(0)) >= 6.0 Then

            If isSendEmailMessage = True Then

                setLastSyncData()

                smp.Credentials = New Net.NetworkCredential(mailUser, mailPassword)
                mail = New MailMessage
                mail.From = New MailAddress(mailUser)

                For n = 0 To xBuild.Count - 1
                    mail.To.Add(xBuild(n))
                Next

                mail.Subject = "แจ้งเตือนแผ่นดินไหว"
                mail.Body = getLastNews()


                smp.EnableSsl = SSL
                smp.Host = HOST
                smp.Port = PORT

                smp.Send(mail)

            End If

        End If

    End Sub

    Private Sub playSoundAlert()


        If isPlaySound = True Then

            My.Computer.Audio.Play(CurDir() & "\sounds\" & soundPath, playmode)

        End If

    End Sub

    Public Sub distroySystemTray()

        Form1.notifyAlert.Visible = False
        Form1.notifyAlert.Dispose()
        Form1.notifyAlert = Nothing

    End Sub


    Private Sub setLastSyncData()

        InfoPanel.setQaukeLevel(Form1.grid.Item(0, 0).Value)
        InfoPanel.setDept(Form1.grid.Item(1, 0).Value)
        InfoPanel.setLat_Long(Form1.grid.Item(2, 0).Value)
        InfoPanel.setLocation(Form1.grid.Item(4, 0).Value)
        InfoPanel.setDateTime(ToLocalTime(Form1.grid.Item(5, 0).Value))
        InfoPanel.setPublisher(Form1.grid.Item(6, 0).Value)
        InfoPanel.setURL(Form1.grid.Item(7, 0).Value)

    End Sub

    Private Function getLastNews() As String

        Return " แผ่นดินไหว " & InfoPanel.getLocation & " ขนาด " & InfoPanel.getQaukeLevel & " ริกเตอร์ " & " ลึก " & InfoPanel.getDept.Replace("km", "กม.") & " เมื่อ " & ToLocalTime(InfoPanel.getDateTime) & " (" & InfoPanel.getPublisher & ")"

    End Function

End Class
