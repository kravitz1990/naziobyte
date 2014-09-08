Imports System.IO
Imports System.Threading
Imports twitter4j.examples.tweets
Imports twitter4j
Imports twitter4j.util


Public Class TwitManage

    Dim oFile As System.IO.File
    Dim oWrite As System.IO.StreamWriter
    Dim trd As Thread
    Dim isAuthen As Boolean


    Private Sub TwitManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If TextBox1.Text = String.Empty Then

            btnChkTw.Enabled = False

        End If


       
        'If File.Exists(pbFile1) And File.Exists(pbFile2) Then
        'ShowInterfaceLogin(True)
        'Else
        'ShowInterfaceLogin(False)
        'End If

    End Sub


    Public Sub readFileSetting()

        ' If File.Exists(pbFile1) And File.Exists(pbFile2) Then

        'Dim rd1 As New StreamReader(pbFile1)
        ' Dim rd2 As New StreamReader(pbFile2)

        'auth1 = rd1.ReadLine 'อ่านไฟล์ aMake_0Auth1.dat
        'auth2 = rd2.ReadLine 'อ่านไฟล์ zMake_0Auth2.dat

        ' rd1.Close()
        ' rd2.Close()


        '  End If

    End Sub


    Public Sub makeFileSetting(ByVal token As String, ByVal tokenSecret As String)

        ' Dim wr1 As StreamWriter
        ' Dim wr2 As StreamWriter
        ' wr1 = File.CreateText(pbFile1)
        ' wr2 = File.CreateText(pbFile2)
        ' wr1.WriteLine(token)
        ' wr2.WriteLine(tokenSecret)
        ' wr1.Close()
        ' wr2.Close()
    End Sub

    Private Sub btnQespin_Click(sender As System.Object, e As System.EventArgs) Handles btnQespin.Click

        Me.Cursor = Cursors.AppStarting
        pcy += 1

        ReDim ntw(pcy)
        ntw(pcy) = New NetTwitter("IwOLgW4ZSoF9XDD0jYMy2g", "VvPQq2iCKwElrLzeVzBVPZGK67BpgY5o6YL66X6BOo")

        Dim AppUrl As String = ntw(pcy).GetAuthorizationURL()
        Process.Start(AppUrl)
        Me.Cursor = Cursors.Default

        'Try
        'Process.Start(getURL_PIN)
        'Catch ex As Exception
        'MsgBox("พบปัญหาการเชื่อมต่อ", MsgBoxStyle.Critical, "Error")
        'End Try

    End Sub

    'Private Function getURL_PIN() As String

    'Return tw.GetAuthorizationLink(consumer, consumersecret)

    ' End Function


    Private Sub btnChkTw_Click(sender As System.Object, e As System.EventArgs) Handles btnChkTw.Click

        Me.Cursor = Cursors.WaitCursor

        Try

            If ntw(pcy).PIN_Login(TextBox1.Text) = True Then

                MsgBox("การเข้าสู่ระบบสำเร็จ", MsgBoxStyle.Information, "  ")
                isSendTwitterMessage = True
                Label1.Visible = False
                TextBox1.Visible = False
                picTrue.Visible = True
                txtLoginSuccess.Visible = True
                txtLoginSuccess.Text = "เข้าสู่ระบบโดย " & ntw(pcy).Name
                btnChkTw.Enabled = False
                btnQespin.Enabled = False
                btnOut.Enabled = True

            Else

                MsgBox("การเข้าสู่ระบบล้มเหลว", MsgBoxStyle.Critical, "  ")
                isSendTwitterMessage = False

            End If

        Catch ex As Exception

            ReDim ntw(pcy)
            ntw(pcy) = New NetTwitter("IwOLgW4ZSoF9XDD0jYMy2g", "VvPQq2iCKwElrLzeVzBVPZGK67BpgY5o6YL66X6BOo")

            Dim AppUrl As String = ntw(pcy).GetAuthorizationURL()
            Process.Start(AppUrl)

        End Try


    
        Me.Cursor = Cursors.Default



        ' If tw.ValidatePIN(TextBox1.Text) = True Then

            'Login success
            ' If MessageBox.Show("คุณต้องการเปิดใช้งานเดี่ยวนี้หรือไม่", "เข้าสู่ระบบสำเร็จ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = MsgBoxResult.Ok Then

            'isSendTwitterMessage = True/
            'oauthtocken = tw.OAuth_Token/
            'oauthtockensecret = tw.OAuth_TokenSecret/
            ' makeFileSetting(oauthtocken, oauthtockensecret)/

            ' auth1 = oauthtocken/
            ' auth2 = oauthtockensecret/

            ' btnChkTw.Enabled = False
            'btnQespin.Enabled = False
            ' btnTwLogout.Enabled = True

            ' frmConfig.txtTwuser.Text = tw.AccountInformation.Name/
            ' frmConfig.txtDateTw.Text = ToLocalTime(DateTime.Now)
            'frmConfig.txtTwCountFollow.Text = tw.Followers.Count & " คน"/
            'frmConfig.txtTwEQ.Text = frmConfig.txtTrackVal.Text & " ริกเตอร์ขึ้นไป"

            '
            ' frmConfig.ApplySetting()
            '  ShowInterfaceLogin(True)
            ' frmConfig.setTwitterGreenFont()

            'frmConfig.ApplySetting()
            'iSaveSettingAsync()

            'End If

            '  Else

            'MessageBox.Show("คุณใส่รหัส PIN ไม่ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'isSendTwitterMessage = False
            ' End If


    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text <> Nothing Then

            btnChkTw.Enabled = True
        Else

            btnChkTw.Enabled = False

        End If

    End Sub


    Public Sub ShowInterfaceLogin(ByVal login As Boolean)

        'If login = True Then


        'btnChkTw.Enabled = False
        'btnQespin.Enabled = False
        'btnTwLogout.Enabled = True
        'Label1.Visible = False
        'TextBox1.Visible = False
        'picTrue.Visible = True
        'txtLoginSuccess.Visible = True

        'tw.AuthenticateWith(consumer, consumersecret, auth1, auth2)
        'Console.WriteLine(consumer & "-----" & consumersecret & "------" & auth1 & "-------" & auth2)
        '    txtLoginSuccess.Text = "เข้าสู่ระบบโดย: " & tw.AccountInformation.Name

        'Else

        'btnChkTw.Enabled = False
        'btnQespin.Enabled = True
        'btnTwLogout.Enabled = False
        'Label1.Visible = True
        'TextBox1.Visible = True
        'picTrue.Visible = False
        'txtLoginSuccess.Visible = False
        'txtLoginSuccess.Text = ""

        'End If


    End Sub


    Private Sub btnOut_Click(sender As System.Object, e As System.EventArgs) Handles btnOut.Click

        If MsgBox("คุณแน่ใจหรือว่าต้องการออกจากระบบ", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "") = MsgBoxResult.Ok Then

            isSendTwitterMessage = False
            btnOut.Enabled = False

            Label1.Visible = True
            TextBox1.Visible = True
            TextBox1.Text = String.Empty
            picTrue.Visible = False
            txtLoginSuccess.Visible = False
            btnChkTw.Enabled = True
            btnQespin.Enabled = True
            btnOut.Enabled = True

        End If

    End Sub

    Private Sub txtLoginSuccess_Click(sender As System.Object, e As System.EventArgs) Handles txtLoginSuccess.Click
        Process.Start("https://twitter.com/")

    End Sub
End Class